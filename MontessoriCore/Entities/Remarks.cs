using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Montessori.Core
{
	public class Remarks
	{
		public int RemarksId { get; set; }
		public string Remark { get; set; }
		public int StudentId { get; set; }
		public string ExaminationId { get; set; }
		public string ExamHeldYear { get; set; }
		public string ClassId { get; set; }

		public static int SaveOrUpdate(Remarks remark)
		{
			var cmd = DataAccess.CreateCommand();
			cmd.CommandText = "usp_Remarks_Save";
			cmd.Parameters.AddWithValue("@StudentId", remark.StudentId);
			cmd.Parameters.AddWithValue("@ClassId", remark.ClassId);
			cmd.Parameters.AddWithValue("@ExaminationId", remark.ExaminationId);
			cmd.Parameters.AddWithValue("@ExamHeldYear", remark.ExamHeldYear);			
			cmd.Parameters.AddWithValue("@Remark", remark.Remark);
			cmd.Parameters.AddWithValue("@RemarkId", remark.RemarksId);
			int i = DataAccess.ExecuteNonQuery(cmd);
			return i;
		}

		public static System.Data.DataTable GetRemark(string examId, string classId, string examHeldYear)
		{
			var cmd = DataAccess.CreateCommand();
			cmd.CommandText = "usp_Remarks_Get";
			cmd.Parameters.AddWithValue("@ExaminationId", examId);
			cmd.Parameters.AddWithValue("@ExamHeldYear", examHeldYear);
			cmd.Parameters.AddWithValue("@ClassId", classId);
			var tbl = DataAccess.ExecuteReaderCommand(cmd);
			return tbl;
		}

		public static string StudentRemarks(string examId, string classId, string studentId)
		{
			var cmd = DataAccess.CreateCommand();
			cmd.CommandText = "usp_Remarks_GetByStudent";
			cmd.Parameters.AddWithValue("@ExaminationId", examId);
			cmd.Parameters.AddWithValue("@StudentId", studentId);
			cmd.Parameters.AddWithValue("@ClassId", classId);
			var remarks = DataAccess.ExecuteScalarCommand(cmd);
			return remarks;
		}
	}
}
