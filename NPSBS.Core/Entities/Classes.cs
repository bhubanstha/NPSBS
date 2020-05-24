using System;
using System.Data;
using Education.Common;
using Utility;

namespace NPSBS.Core
{
    public class Classes : ICrud<Classes>
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        private int rowsAffected = 0;
        private readonly DataAccess dataAccess;

        public Classes()
        {
            dataAccess = new DataAccess(App.NPSBS);
        }


        public int Save(Classes obj)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_Class_Save";
            cmd.Parameters.AddWithValue("@ClassName", obj.ClassName);
            rowsAffected = dataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Update(Classes obj)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_Class_Update";
            cmd.Parameters.AddWithValue("@ClassId", obj.ClassId);
            cmd.Parameters.AddWithValue("@ClassName", obj.ClassName);
            rowsAffected = dataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Delete(int Id)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_Class_Delete";
            cmd.Parameters.AddWithValue("@ClassId", Id);
            rowsAffected = dataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public DataTable Select()
        {
            return StartupCache.Class;
        }

        public DataTable SelectById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
