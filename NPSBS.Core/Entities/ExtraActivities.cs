using Education.Common;
using System.Data;
using Utility;

namespace NPSBS.Core
{
    public class ExtraActivities
    {
        private DataAccess dataAccess;
        public string RollNumber { get; set; }
        public int SchoolDays { get; set; }
        public int PresentDays { get; set; }
        public string ActivitiesYear { get; set; }
        public int ExaminationId { get; set; }
        public string Drawing { get; set; }
        public string Games { get; set; }
        public string Conduct { get; set; }
        public string PersonalClenliness { get; set; }
        public string Cooperation { get; set; }
        public int StudentId { get; set; }

        public ExtraActivities()
        {
            dataAccess = new DataAccess(App.NPSBS);
        }

        public int Save(ExtraActivities activities)
        {
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_StudentExtraActivities_Save";
            cmd.Parameters.AddWithValue("@StudentId", activities.StudentId);
            cmd.Parameters.AddWithValue("@ActivitiesYear", activities.ActivitiesYear);
            cmd.Parameters.AddWithValue("@ExaminationId", activities.ExaminationId);
            cmd.Parameters.AddWithValue("@SchoolDays", activities.SchoolDays);
            cmd.Parameters.AddWithValue("@PresentDays", activities.PresentDays);
            cmd.Parameters.AddWithValue("@Drawing", activities.Drawing);
            cmd.Parameters.AddWithValue("@Games", activities.Games);
            cmd.Parameters.AddWithValue("@Conduct", activities.Conduct);
            cmd.Parameters.AddWithValue("@PersonalCleanliness", activities.PersonalClenliness);
            cmd.Parameters.AddWithValue("@Cooperation", activities.Cooperation);
            cmd.Parameters.AddWithValue("@RollNumber", activities.RollNumber);
            int i = dataAccess.ExecuteNonQuery(cmd);
            return i;
        }

        public static DataTable GetExtraActivities(string year, string examinationId)
        {
            DataAccess dataAccess = new DataAccess(App.NPSBS);
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_StudentExtraActivities_Get";
            cmd.Parameters.AddWithValue("@Year", year);
            cmd.Parameters.AddWithValue("@Examination", examinationId);
            var tbl = dataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }

    }
}
