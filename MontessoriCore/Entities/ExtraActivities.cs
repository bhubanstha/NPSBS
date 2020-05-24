using Education.Common;
using System.Data;
using Utility;

namespace Montessori.Core
{
    public class ExtraActivities
    {
        public string StudentId { get; set; }
        public int SchoolDays { get; set; }
        public int PresentDays { get; set; }
        public string ActivitiesYear { get; set; }
        public int ExaminationId { get; set; }

        public string ReadingAndWriting { get; set; }
        public string RecognitionofLetter { get; set; }
        public string English { get; set; }
        public string Nepali { get; set; }
        public string CopyingSkill { get; set; }
        public string StudentsAcademicAttitude { get; set; }
        public string Concentration { get; set; }
        public string Cooperation { get; set; }
        public string Memory { get; set; }
        public string Curiosity { get; set; }
        public string Understanding { get; set; }
        public string StudentDepartment { get; set; }
        public string Conduct { get; set; }
        public string Neatness { get; set; }
        public string Punctuality { get; set; }
        public string Politeness { get; set; }
        public string HeightAndWeight { get; set; }
        public string ExtraCurricular { get; set; }
        public string Drill { get; set; }
        public string Dance { get; set; }
        public string Rhymes { get; set; }

        private DataAccess dataAccess;
        private static DataAccess _dataAccess;

        public ExtraActivities()
        {
            dataAccess = new DataAccess(App.KidsZone);
        }
        static ExtraActivities()
        {
            _dataAccess = new DataAccess(App.KidsZone);
        }
        public int Save(ExtraActivities activities)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_StudentExtraActivities_Save";
            cmd.Parameters.AddWithValue("@StudentId", activities.StudentId);
            cmd.Parameters.AddWithValue("@ActivitiesYear", activities.ActivitiesYear.ToUpper());
            cmd.Parameters.AddWithValue("@ExaminationId", activities.ExaminationId);
            cmd.Parameters.AddWithValue("@SchoolDays", activities.SchoolDays);
            cmd.Parameters.AddWithValue("@PresentDays", activities.PresentDays);
            cmd.Parameters.AddWithValue("@ReadingAndWriting", "");
            cmd.Parameters.AddWithValue("@RecognitionofLetter", "");
            cmd.Parameters.AddWithValue("@English", activities.English.ToUpper());
            cmd.Parameters.AddWithValue("@Nepali", activities.Nepali.ToUpper());
            cmd.Parameters.AddWithValue("@CopyingSkill", activities.CopyingSkill.ToUpper());
            cmd.Parameters.AddWithValue("@StudentsAcademicAttitude", "");
            cmd.Parameters.AddWithValue("@Concentration", activities.Concentration.ToUpper());
            cmd.Parameters.AddWithValue("@Cooperation", activities.Cooperation.ToUpper());
            cmd.Parameters.AddWithValue("@Memory", activities.Memory.ToUpper());
            cmd.Parameters.AddWithValue("@Curiosity", activities.Curiosity.ToUpper());
            cmd.Parameters.AddWithValue("@Understanding", activities.Understanding.ToUpper());
            cmd.Parameters.AddWithValue("@StudentDepartment", "");
            cmd.Parameters.AddWithValue("@Conduct", activities.Conduct.ToUpper());
            cmd.Parameters.AddWithValue("@Neatness", activities.Neatness.ToUpper());
            cmd.Parameters.AddWithValue("@Punctuality", activities.Punctuality.ToUpper());
            cmd.Parameters.AddWithValue("@Politeness", activities.Politeness.ToUpper());
            cmd.Parameters.AddWithValue("@HeightAndWeight", activities.HeightAndWeight.ToUpper());
            cmd.Parameters.AddWithValue("@ExtraCurricular", "");
            cmd.Parameters.AddWithValue("@Drill", activities.Drill.ToUpper());
            cmd.Parameters.AddWithValue("@Dance", activities.Dance.ToUpper());
            cmd.Parameters.AddWithValue("@Rhymes", activities.Rhymes.ToUpper());
            int i = dataAccess.ExecuteNonQuery(cmd);
            return i;
        }

        public static DataTable GetExtraActivities(string year, string examinationId, string classId)
        {
            var cmd = _dataAccess.CreateCommand();
            cmd.CommandText = "usp_StudentExtraActivities_Get";
            cmd.Parameters.AddWithValue("@Year", year);
            cmd.Parameters.AddWithValue("@Examination", examinationId);
            cmd.Parameters.AddWithValue("@ClassId", classId);
            var tbl = _dataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }


        public static DataTable GetStudentActivities(int studentId, int examinationId)
        {
             var cmd = _dataAccess.CreateCommand();
             cmd.CommandText = "Extra_Activities";
             cmd.Parameters.AddWithValue("@StudentId", studentId);
             cmd.Parameters.AddWithValue("@ExaminationId", examinationId);
            var tbl = _dataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }

    }
}
