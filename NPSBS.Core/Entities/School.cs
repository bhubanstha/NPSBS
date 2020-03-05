using System;
using System.Data;

namespace NPSBS.Core
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string  EstiblishedYear { get; set; }
        public string Slogan { get; set; }
        public byte[] Logo { get; set; }


        public School()
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "GetSchoolInfo";
            DataTable tbl = DataAccess.ExecuteReaderCommand(cmd);
            if (tbl.Rows.Count > 0)
            {
                this.Id = Convert.ToInt32(tbl.Rows[0][0]);
                this.SchoolName = tbl.Rows[0][1].ToString();
                this.ShortName = tbl.Rows[0][2].ToString();
                this.Address = tbl.Rows[0][3].ToString();
                this.PhoneNo = tbl.Rows[0][4].ToString();
                this.Email = tbl.Rows[0][5].ToString();
                this.WebSite = tbl.Rows[0][6].ToString();
                this.Logo = (byte[])tbl.Rows[0][7];
                this.EstiblishedYear = tbl.Rows[0][8].ToString();
                this.Slogan = tbl.Rows[0][9].ToString();
            }
        }

        public int SaveOrUdate()
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "SaveUpdateSchool";
            cmd.Parameters.AddWithValue("@Id", this.Id);
            cmd.Parameters.AddWithValue("@SchoolName", this.SchoolName);
            cmd.Parameters.AddWithValue("@ShortName", this.ShortName);
            cmd.Parameters.AddWithValue("@Address", this.Address);
            cmd.Parameters.AddWithValue("@PhoneNo", this.PhoneNo);
            cmd.Parameters.AddWithValue("@Email", this.Email);
            cmd.Parameters.AddWithValue("@WebSite", this.WebSite);
            cmd.Parameters.AddWithValue("@Logo", this.Logo);
            cmd.Parameters.AddWithValue("@EstiblishedYear", this.EstiblishedYear);
            cmd.Parameters.AddWithValue("@Slogan", this.Slogan);
            return Convert.ToInt32(DataAccess.ExecuteScalarCommand(cmd));
        }


    }
}
