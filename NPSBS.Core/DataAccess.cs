using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Globalization;

namespace NPSBS.Core
{
    public class DataAccess
    {


        public static SqlCommand CreateCommand()
        {
            var con = new SqlConnection { ConnectionString = ConnectionString() };
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

        public static string ConnectionString()
        {
            var connectionString = "";
            try
            {
                string source = ConfigurationManager.AppSettings["DataSource"];
                string user = ConfigurationManager.AppSettings["UserName"];
                string db = ConfigurationManager.AppSettings["Database_NPSBS"];
                string pwd = ConfigurationManager.AppSettings["Password"];
                connectionString = "data source = " + source + "; database=" + db + "; user id=" + user + "; password=" + pwd;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(CultureInfo.InvariantCulture), "Connection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connectionString;
        }

        ~DataAccess()
        {
            GC.Collect();

        }
    }

}


    
    

