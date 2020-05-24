using Education.Common;
using Utility;

namespace NPSBS.Core
{
    public class Subject : ICrud<Subject>
    {
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
        public string SubjectName { get; set; }
        public decimal Practicalmarks { get; set; }
        public decimal Theorymarks { get; set; }
        private int rowsAffected = 0;
        private DataAccess dataAccess;

        public Subject()
        {
            dataAccess = new DataAccess(App.NPSBS);
        }

        public int Save(Subject obj)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_Subject_Save";
            cmd.Parameters.AddWithValue("@SubjectName", obj.SubjectName);
            cmd.Parameters.AddWithValue("@ClassId", obj.ClassId);
            cmd.Parameters.AddWithValue("@ThoryMarks", obj.Theorymarks);
            cmd.Parameters.AddWithValue("@PracticalMarks", obj.Practicalmarks);
            rowsAffected = dataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Update(Subject obj)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_Subject_Update";
            cmd.Parameters.AddWithValue("@SubjectName", obj.SubjectName);
            cmd.Parameters.AddWithValue("@ClassId", obj.ClassId);
            cmd.Parameters.AddWithValue("@ThoryMarks", obj.Theorymarks);
            cmd.Parameters.AddWithValue("@PracticalMarks", obj.Practicalmarks);
            cmd.Parameters.AddWithValue("@SubjectId", obj.SubjectId);
            rowsAffected = dataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Delete(int Id)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_Subject_Delete";
            cmd.Parameters.AddWithValue("@SubjectId", Id);
            rowsAffected = dataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public System.Data.DataTable Select()
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_Subject_Select";
            var tbl = dataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }

        public System.Data.DataTable SelectById(int id)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_Subject_SelectById";
            cmd.Parameters.AddWithValue("@SubjectId", id);
            var tbl = dataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }

        public System.Data.DataTable SubjectByClassId(string classId)
        {
            classId = classId == "System.Data.DataRowView" ? "0" : classId;
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_Subject_ByClass";
            cmd.Parameters.AddWithValue("@ClassId", classId);
            var tbl = dataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }
    }
}
