using System;
using System.Data;
using Education.Common;
using Utility;

namespace Montessori.Core
{
	public class Exam : ICrud<Exam>
	{
		public int ExamId { get; set; }
		public string ExamName { get; set; }

		public int ExaminationId { get; set; }
		public string ExamHeldYear { get; set; }
		public DateTime ResultPrintDate { get; set; }

		private int rowsAffected = 0;
		private DataAccess dataAccess;

		public Exam()
		{
			dataAccess = new DataAccess(App.KidsZone);
		}

		public int Save(Exam obj)
		{
			var cmd = dataAccess.CreateCommand();
			cmd.CommandText = "usp_Exam_Save";
			cmd.Parameters.AddWithValue("@HeldYear", obj.ExamHeldYear);
			cmd.Parameters.AddWithValue("@ExamId", obj.ExamId);
			cmd.Parameters.AddWithValue("@PrintDate", obj.ResultPrintDate);
			rowsAffected = dataAccess.ExecuteNonQuery(cmd);
			return rowsAffected;
		}

		public int Update(Exam obj)
		{
			var cmd = dataAccess.CreateCommand();
			cmd.CommandText = "usp_Exam_Update";
			cmd.Parameters.AddWithValue("@HeldYear", obj.ExamHeldYear);
			cmd.Parameters.AddWithValue("@ExamId", obj.ExamId);
			cmd.Parameters.AddWithValue("@PrintDate", obj.ResultPrintDate);
			cmd.Parameters.AddWithValue("@ExaminationID", obj.ExaminationId);
			rowsAffected = dataAccess.ExecuteNonQuery(cmd);
			return rowsAffected;
		}

		public int Delete(int Id)
		{
			var cmd = dataAccess.CreateCommand();
			cmd.CommandText = "usp_Exam_Delete";
			cmd.Parameters.AddWithValue("@ExaminationID", Id);
			rowsAffected = dataAccess.ExecuteNonQuery(cmd);
			return rowsAffected;
		}

		public DataTable Select()
		{
			var cmd = dataAccess.CreateCommand();
			cmd.CommandText = "usp_Examination_Select";
			var tbl = dataAccess.ExecuteReaderCommand(cmd);
			return tbl;
		}

		public DataTable GetExaminationByYear(string year)
		{
			var cmd = dataAccess.CreateCommand();
			cmd.CommandText = "usp_Examination_GetByYear";
			cmd.Parameters.AddWithValue("@Year", year);
			var tbl = dataAccess.ExecuteReaderCommand(cmd);
			return tbl;
		}

		public DataTable SelectById(int id)
		{
			var cmd = dataAccess.CreateCommand();
			cmd.CommandText = "usp_Examination_SelectById";
			cmd.Parameters.AddWithValue("@ExamId", id);
			var tbl = dataAccess.ExecuteReaderCommand(cmd);
			return tbl;
		}


		public DataTable GetExams()
		{
			return StartupCache.Exam;
			/*var cmd = DataAccess.CreateCommand();
			cmd.CommandText = "usp_Exam_Select";
			var tbl = DataAccess.ExecuteReaderCommand(cmd);
			return tbl;
			 * */
		}

		public DataTable GetExamsByYear(string year)
		{
			var cmd = dataAccess.CreateCommand();
			cmd.CommandText = "usp_Exam_ByYear";
			cmd.Parameters.AddWithValue("@Year", year);
			var tbl = dataAccess.ExecuteReaderCommand(cmd);
			return tbl;
		}

		public int SubmitMark(string classId, string examinationId, string subjectId, string rollNumber, string studentId, string grade, string examyear)
		{
			var cmd = dataAccess.CreateCommand();
			cmd.CommandText = "usp_StudentExam_Save";
			cmd.Parameters.AddWithValue("@ClassId", classId);
			cmd.Parameters.AddWithValue("@ExaminationId", examinationId);
			cmd.Parameters.AddWithValue("@SubjectId", subjectId);
			cmd.Parameters.AddWithValue("@RollNumber", rollNumber);
			cmd.Parameters.AddWithValue("@Grade", grade);
			cmd.Parameters.AddWithValue("@ExamYear", examyear);
			cmd.Parameters.AddWithValue("@StudentId", studentId);
			rowsAffected += dataAccess.ExecuteNonQuery(cmd);
			return rowsAffected;
		}

		public bool CheckTheory(decimal theoryMark, string subjectId)
		{
			var cmd = dataAccess.CreateCommand();
			cmd.CommandText = "usp_Subject_CheckTheory";
			cmd.Parameters.AddWithValue("@Mark", theoryMark);
			cmd.Parameters.AddWithValue("@SubjectId", subjectId);
			var status = Convert.ToBoolean(dataAccess.ExecuteScalarCommand(cmd));
			return status;
		}

		public bool CheckPractical(decimal practicalMark, string subjectId)
		{
			var cmd = dataAccess.CreateCommand();
			cmd.CommandText = "usp_Subject_CheckPractical";
			cmd.Parameters.AddWithValue("@Mark", practicalMark);
			cmd.Parameters.AddWithValue("@SubjectId", subjectId);
			var status = Convert.ToBoolean(dataAccess.ExecuteScalarCommand(cmd));
			return status;
		}


		public DataSet GetClassResult(int ExamId, int ClassId, int year)
		{
			var cmd = dataAccess.CreateCommand();
			cmd.CommandText = "usp_ExamResult";
			cmd.Parameters.AddWithValue("@ExaminationId", ExamId);
			cmd.Parameters.AddWithValue("@ClassId", ClassId);
			cmd.Parameters.AddWithValue("@Year", year);
			var status = dataAccess.ExecuteDataSet(cmd);
			return status;
		}

		public DataTable GetExtraActivities(int StudentId, int ExaminationId)
		{
			var cmd = dataAccess.CreateCommand();
			cmd.CommandText = "usp_GetStudentActivities";
			cmd.Parameters.AddWithValue("@ExaminationId", ExaminationId);
			cmd.Parameters.AddWithValue("@StudentId", StudentId);
			var tbl = dataAccess.ExecuteReaderCommand(cmd);
			return tbl;
		}

	}
}
