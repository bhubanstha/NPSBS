using System;
using System.Collections.Generic;
using System.Data;
using Education.Common;
using Utility;

namespace Montessori.Core
{
    public class GradingSystem : ICrud<GradingSystem>
    {
        public int GradingSystemId { get; set; }
        public decimal MarksFrom { get; set; }
        public decimal MarksTo { get; set; }
        public string Grade { get; set; }
        public string LetterGrade { get; set; }
        public decimal GradePoint { get; set; }
        public string EquivalentMarks { get; set; }
        public string Remarks { get; set; }

        private DataAccess dataAccess;


        public GradingSystem()
        {
            dataAccess = new DataAccess(App.KidsZone);
        }
        public int Save(GradingSystem obj)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_GradingSystem_Save";
            cmd.Parameters.AddWithValue("@MarksFrom", obj.MarksFrom);
            cmd.Parameters.AddWithValue("@MarksTo", obj.MarksTo);
            cmd.Parameters.AddWithValue("@Grade", obj.Grade);
            cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
            int rowsAffected = dataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Update(GradingSystem obj)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_GradingSystem_Update";
            cmd.Parameters.AddWithValue("@MarksFrom", obj.MarksFrom);
            cmd.Parameters.AddWithValue("@MarksTo", obj.MarksTo);
            cmd.Parameters.AddWithValue("@Grade", obj.Grade);
            cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
            cmd.Parameters.AddWithValue("@GradingId", obj.GradingSystemId);
            int rowsAffected = dataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Delete(int Id)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_GradingSystem_Delete";
            cmd.Parameters.AddWithValue("@GradingId", Id);
            int rowsAffected = dataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public DataTable Select()
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_GradingSystem_Select";
            var tbl = dataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }

        public DataTable SelectById(int id)
        {
            throw new NotImplementedException();
        }


        public List<GradingSystem> GradingInfo()
        {
            return StartupCache.GradingSystem;
        }


        public string ObtainGrade(decimal obtainMarks, decimal fullMark)
        {            
            if (fullMark < 1) fullMark = 1;
            obtainMarks = (obtainMarks * 100) / fullMark;
            List<GradingSystem> gs = StartupCache.GradingSystem;
            var a = gs.Find(g => obtainMarks >= g.MarksFrom && obtainMarks <= g.MarksTo);
            var b = a.LetterGrade;
            if (b == "D" || b == "E" || b == "N") b = "-";
            return b;
        }

        public decimal ObtainGradePoint(decimal obtainMarks, decimal fullMark)
        {
            if (fullMark < 1) fullMark = 1;
            obtainMarks = (obtainMarks * 100) / fullMark;
            List<GradingSystem> gs = StartupCache.GradingSystem;
            var a = gs.Find(g => obtainMarks >= g.MarksFrom && obtainMarks <= g.MarksTo);
            var b = a.GradePoint;
            return b;
        }

        public decimal GPA(decimal totalGPa, int subject)
        {
            return totalGPa / subject;
        }

        public string AverageGrade(decimal gpa)
        {
            List<GradingSystem> gs = StartupCache.GradingSystem;
            var a = gs.Find(g => gpa >= g.GradePoint);
            var b = a.LetterGrade;
            if (b == "D" || b == "E" || b == "N") b = "-";
            return b;
        }

        public string GradeRemarks(decimal gpa)
        {
            List<GradingSystem> gs = StartupCache.GradingSystem;
            var a = gs.Find(g => gpa >= g.GradePoint);
            var b = a.Remarks;
            return b;
        }

    }
}
