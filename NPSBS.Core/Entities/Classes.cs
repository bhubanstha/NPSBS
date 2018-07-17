using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace NPSBS.Core
{
    public class Classes : ICrud<Classes>
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        private int rowsAffected = 0;

        public int Save(Classes obj)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Class_Save";
            cmd.Parameters.AddWithValue("@ClassName", obj.ClassName);
            rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Update(Classes obj)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Class_Update";
            cmd.Parameters.AddWithValue("@ClassId", obj.ClassId);
            cmd.Parameters.AddWithValue("@ClassName", obj.ClassName);
            rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Delete(int Id)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Class_Delete";
            cmd.Parameters.AddWithValue("@ClassId", Id);
            rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public System.Data.DataTable Select()
        {
            return StartupCache.Class;
            /*
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Class_Select";
            DataTable tbl = DataAccess.ExecuteReaderCommand(cmd);
            return tbl;
             * */
        }

        public System.Data.DataTable SelectById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
