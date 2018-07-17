using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPSBS.Core
{
    public class ExtraActivities
    {
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


        public int Save(ExtraActivities activities)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_StudentExtraActivities_Save";
            cmd.Parameters.AddWithValue("@RollNumber", activities.RollNumber);
            cmd.Parameters.AddWithValue("@ActivitiesYear", activities.ActivitiesYear);
            cmd.Parameters.AddWithValue("@ExaminationId", activities.ExaminationId);
            cmd.Parameters.AddWithValue("@SchoolDays", activities.SchoolDays);
            cmd.Parameters.AddWithValue("@PresentDays", activities.PresentDays);
            cmd.Parameters.AddWithValue("@Drawing", activities.Drawing);
            cmd.Parameters.AddWithValue("@Games", activities.Games);
            cmd.Parameters.AddWithValue("@Conduct", activities.Conduct);
            cmd.Parameters.AddWithValue("@PersonalCleanliness", activities.PersonalClenliness);
            cmd.Parameters.AddWithValue("@Cooperation", activities.Cooperation);
            int i = DataAccess.ExecuteNonQuery(cmd);
            return i;
        }

        public static System.Data.DataTable GetExtraActivities(string year, string examinationId)
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_StudentExtraActivities_Get";
            cmd.Parameters.AddWithValue("@Year", year);
            cmd.Parameters.AddWithValue("@Examination", examinationId);
            var tbl = DataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }

    }
}
