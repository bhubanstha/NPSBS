using System;
using System.Data;
using System.Data.SqlClient;
using Utility;

namespace Montessori.Core
{
    public class DataAccess
    {

        public DataAccess()
        {
            Connection con = Connection.Instance;
        }

        static DataAccess()
        {
            Connection con = Connection.Instance;
        }

        public static SqlCommand CreateCommand()
        {
            var con = new SqlConnection { ConnectionString = Connection.GetMontessoriConnection() };
            var cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public static DataTable ExecuteReaderCommand(SqlCommand cmd)
        {
            DataTable tbl = new DataTable();
            SqlDataReader rdr =null;
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

        public static int ExecuteNonQuery(SqlCommand cmd)
        {
            var i = -1;
            try
            {
                cmd.Connection.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Connection.Close();
            }
            
            
            return i;
        }

        public static DataSet ExecuteDataSet(SqlCommand cmd)
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
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return ds;
        }

        public static string ExecuteScalarCommand(SqlCommand cmd)
        {
            var data = "";
            try
            {
                cmd.Connection.Open();
                data = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
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


    
    

