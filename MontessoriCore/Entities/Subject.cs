using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Montessori.Core
{
    public class Subject : ICrud<Subject>
    {
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
        public string SubjectName { get; set; }
        public decimal Practicalmarks { get; set; }
        public decimal Theorymarks { get; set; }
        private int rowsAffected = 0;


        public int Save(Subject obj)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Subject_Save";
            cmd.Parameters.AddWithValue("@SubjectName", obj.SubjectName);
            cmd.Parameters.AddWithValue("@ClassId", obj.ClassId);
            rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Update(Subject obj)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Subject_Update";
            cmd.Parameters.AddWithValue("@SubjectName", obj.SubjectName);
            cmd.Parameters.AddWithValue("@ClassId", obj.ClassId);
            cmd.Parameters.AddWithValue("@SubjectId", obj.SubjectId);
            rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Delete(int Id)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Subject_Delete";
            cmd.Parameters.AddWithValue("@SubjectId", Id);
            rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public System.Data.DataTable Select()
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Subject_Select";
            var tbl = DataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }

        public System.Data.DataTable SelectById(int id)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Subject_SelectById";
            cmd.Parameters.AddWithValue("@SubjectId", id);
            var tbl = DataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }

        public System.Data.DataTable SubjectByClassId(string classId)
        {
            classId = classId == "System.Data.DataRowView" ? "0" : classId;
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Subject_ByClass";
            cmd.Parameters.AddWithValue("@ClassId", classId);
            var tbl = DataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }
    }
}
