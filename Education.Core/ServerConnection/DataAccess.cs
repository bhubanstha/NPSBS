using System;
using System.Data;
using System.Data.SqlClient;
using Utility;

namespace Education.Common
{

    public class DataAccess
    {
        private readonly App _app;
        public DataAccess(App app)
        {
            _app = app;
            Setting con = Setting.Instance;
        }


        public SqlCommand CreateCommand()
        {
            var con = new SqlConnection {
                ConnectionString = _app == App.NPSBS ?
                        Setting.GetNPSBSConnection() :
                        Setting.GetMontessoriConnection()
            };
            var cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public DataTable ExecuteReaderCommand(SqlCommand cmd)
        {
            DataTable tbl = new DataTable();
            SqlDataReader rdr = null;
            try
            {
                cmd.Connection.Open();
                rdr = cmd.ExecuteReader();
                tbl = new DataTable();
                tbl.Load(rdr);

            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                rdr.Close();
                cmd.Connection.Close();
            }
            return tbl;
        }

        public int ExecuteNonQuery(SqlCommand cmd)
        {
            var i = -1;
            try
            {
                cmd.Connection.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch
            {
                //throw ex;
                //MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Connection.Close();
            }


            return i;
        }

        public DataSet ExecuteDataSet(SqlCommand cmd)
        {
            DataSet ds = null;
            SqlDataAdapter adap = null;
            try
            {
                cmd.Connection.Open();
                adap = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adap.Fill(ds);

            }
            catch 
            {

                //throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return ds;
        }

        public string ExecuteScalarCommand(SqlCommand cmd)
        {
            var data = "";
            try
            {
                cmd.Connection.Open();
                data = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                // throw ex;
                //MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Connection.Close();
            }

            return data;
        }


        ~DataAccess()
        {
            GC.Collect();

        }
    }

}
