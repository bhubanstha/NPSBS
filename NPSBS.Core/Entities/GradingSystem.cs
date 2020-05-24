using System;
using System.Collections.Generic;
using System.Data;
using Education.Common;
using Utility;

namespace NPSBS.Core
{
    public class GradingSystem : ICrud<GradingSystem>
    {
        public int GradingSystemId { get; set; }
        public decimal MarksFrom { get; set; }
        public decimal MarksTo { get; set; }
        public string Grade { get; set; }
        public string LetterGrade { get; set; }
        public decimal MinGradePoint { get; set; }
        public decimal MaxGradePoint { get; set; }
        public string EquivalentMarks { get; set; }
        public string Remarks { get; set; }
        private int rowsAffected = 0;
        private DataAccess dataAccess;

        public GradingSystem()
        {
            dataAccess = new DataAccess(App.NPSBS);
        }
        public int Save(GradingSystem obj)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_GradingSystem_Save";
            cmd.Parameters.AddWithValue("@MarksFrom", obj.MarksFrom);
            cmd.Parameters.AddWithValue("@MarksTo", obj.MarksTo);
            cmd.Parameters.AddWithValue("@Grade", obj.Grade);
            cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
            rowsAffected = dataAccess.ExecuteNonQuery(cmd);
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
            rowsAffected = dataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public int Delete(int Id)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_GradingSystem_Delete";
            cmd.Parameters.AddWithValue("@GradingId", Id);
            rowsAffected = dataAccess.ExecuteNonQuery(cmd);
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
            if (obtainMarks == 0) return "-";
            if (fullMark < 1) fullMark = 1;
            obtainMarks = (obtainMarks * 100) / fullMark;
            List<GradingSystem> gs = StartupCache.GradingSystem;
            var a = gs.Find(g => obtainMarks >= g.MarksFrom && obtainMarks <= g.MarksTo);
            var b = a.LetterGrade;
            if ( b == "N") b = "-";
            return b;
        }

        public decimal ObtainGradePoint(decimal obtainMarks, decimal fullMark)
        {
            if (fullMark < 1) fullMark = 1;
            obtainMarks = (obtainMarks * 100) / fullMark;
            List<GradingSystem> gs = StartupCache.GradingSystem;
            var a = gs.Find(g => obtainMarks >= g.MarksFrom && obtainMarks <= g.MarksTo);
            var b = a.MaxGradePoint;
            return b;
        }

        public decimal GPA(decimal totalGPa, int subject)
        {
            return totalGPa / subject;
        }

        public string AverageGrade(decimal gpa)
        {
            List<GradingSystem> gs = StartupCache.GradingSystem;
            //var a = gs.Find(g => gpa >= g.GradePoint);
            var a = gs.Find(g => gpa>= g.MinGradePoint && gpa <= g.MaxGradePoint);
            var b = a.LetterGrade;
            //if (b == "N") b = "-";
            return b;
        }

        public string GradeRemarks(decimal gpa)
        {
            List<GradingSystem> gs = StartupCache.GradingSystem;
            var a = gs.Find(g => gpa >= g.MinGradePoint && gpa <= g.MaxGradePoint);
            var b = a.Remarks;
            return b;
        }

    }
}
