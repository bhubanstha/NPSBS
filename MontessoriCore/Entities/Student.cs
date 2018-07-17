﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Montessori.Core
{
    public class Student : ICrud<Student>
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public char Gender { get; set; }
        public int ClassId { get; set; }
        public string EnrolledYear { get; set; }
        public string RollNumber { get; set; }
        private int rowsAffected = 0;

        public int Save(Student obj)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Student_Save";
            cmd.Parameters.AddWithValue("@StudentName", obj.StudentName);
            cmd.Parameters.AddWithValue("@Gender", obj.Gender);
            cmd.Parameters.AddWithValue("@ClassId", obj.ClassId);
            cmd.Parameters.AddWithValue("@EnrolledYear", obj.EnrolledYear);
            cmd.Parameters.AddWithValue("@RollNumber", obj.RollNumber);
            rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Update(Student obj)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Student_Update";
            cmd.Parameters.AddWithValue("@StudentName", obj.StudentName);
            cmd.Parameters.AddWithValue("@Gender", obj.Gender);
            cmd.Parameters.AddWithValue("@ClassId", obj.ClassId);
            cmd.Parameters.AddWithValue("@EnrolledYear", obj.EnrolledYear);
            cmd.Parameters.AddWithValue("@RollNumber", obj.RollNumber);
            cmd.Parameters.AddWithValue("@StudentId", obj.StudentId);
            rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Delete(int Id)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Student_Delete";
            cmd.Parameters.AddWithValue("@StudentId", Id);
            rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public System.Data.DataTable Select()
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Student_Select";
            var tbl = DataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }
        public System.Data.DataTable Search(string name, string classId, string academicYear)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Student_Search";
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@ClassId", classId);
            cmd.Parameters.AddWithValue("@AcademicYear", academicYear);
            var tbl = DataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }

        public System.Data.DataTable GetTransferStudent(string classId, string academicYear)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Student_Transfer";
            cmd.Parameters.AddWithValue("@ClassId", classId);
            cmd.Parameters.AddWithValue("@AcademicYear", academicYear);
            var tbl = DataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }

        public System.Data.DataTable SelectById(int id)
        {
            throw new NotImplementedException();
        }
        public System.Data.DataTable GetStudentById(string id, string enrolledYear)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Student_SelectById";
            cmd.Parameters.AddWithValue("@StudentId", id);
            cmd.Parameters.AddWithValue("@EnrolledYear", enrolledYear);
            var tbl = DataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }
        public int Transfer(string rollNumber, string classId, string academicYear, string studentId)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Student_TransferStudent";
            cmd.Parameters.AddWithValue("@StudentId", studentId);
            cmd.Parameters.AddWithValue("@ClassId", classId);            
            cmd.Parameters.AddWithValue("@EnrolledYear", academicYear);
            cmd.Parameters.AddWithValue("@RollNumber", rollNumber);
            rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int BulkUpload(System.Data.DataTable tbl)
        {
            rowsAffected = 0;
            if (tbl.Rows.Count > 0)
            {
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    string name = tbl.Rows[i]["Name"].ToString();
                    string className = tbl.Rows[i]["Class"].ToString();
                    string AcademicYear = tbl.Rows[i]["Academic Year"].ToString();
                    string rollNumber = tbl.Rows[i]["Roll Number"].ToString();
                    string gender = tbl.Rows[i]["Gender"].ToString();

                    var cmd = DataAccess.CreateCommand();
                    cmd.CommandText = "usp_Student_BulkInsert";
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@ClassName", className);
                    cmd.Parameters.AddWithValue("@Enrolledyear", AcademicYear);
                    cmd.Parameters.AddWithValue("@RollNumber", rollNumber);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    rowsAffected += DataAccess.ExecuteNonQuery(cmd);
                }
            }
            return rowsAffected > 0 ? rowsAffected / 2 : rowsAffected;
        }


        public System.Data.DataTable GetStudentByAcademicYearClass(string classId, string academicYear, string subjectId, string examinationId)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Student_Select_By_Class_Year";
            cmd.Parameters.AddWithValue("@EnrolledYear", academicYear);
            cmd.Parameters.AddWithValue("@ClassId", classId);
            cmd.Parameters.AddWithValue("@SubjectId", subjectId);
            cmd.Parameters.AddWithValue("@ExaminationId", examinationId);
            var tbl = DataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }

        public List<string> AcademicYears()
        {
            int currentEnglishYear = DateTime.Now.Year;
            List<string> years = new List<string>();
            for (int i = currentEnglishYear + 53; i < currentEnglishYear + 59; i++)
            {
                years.Add(i.ToString());
            }
            return years;
        }

        public List<string> StudentList()
        {
            List<string> students = new List<string>();
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Student_Names";
            var tbl = DataAccess.ExecuteReaderCommand(cmd);
            if (tbl.Rows.Count > 0)
            {
                for (int i = 0; i < tbl.Rows.Count; i++)
			    {
			     students.Add(tbl.Rows[i][0].ToString());
			    }                
            }
            return students;
        }

       
    }
}
