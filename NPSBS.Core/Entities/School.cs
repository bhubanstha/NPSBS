using System;
using System.Data;

namespace NPSBS.Core
{
    public class School
    {
        private int _id = -1;
        private string _schoolName = "National Peace Secondary Boarding School";
        private string _shortName = "NPSBS";
        private string _address = "Gongabu, kathmandu, Nepal";
        private string _phone = "123456";
        private string _email = "info@npsbs.edu.np";
        private string _website = "npsbs.edu.np";
        private string _establishedYear = "1996";
        private string _slogan = "";


        public int Id { get { return _id; } set { _id = value; } }
        public string SchoolName { get { return _schoolName; } set { _schoolName = value; } }
        public string ShortName { get { return _shortName; } set { _shortName = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string PhoneNo { get { return _phone; } set { _phone = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string WebSite { get { return _website; } set { _website = value; } }
        public string  EstiblishedYear { get { return _establishedYear; } set { _establishedYear = value; } }
        public string Slogan { get { return _slogan; } set { _slogan = value; } }
        public byte[] Logo { get; set; }


        public School()
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "GetSchoolInfo";
            DataTable tbl = DataAccess.ExecuteReaderCommand(cmd);
            if (tbl.Rows.Count > 0)
            {
                this._id = Convert.ToInt32(tbl.Rows[0][0]);
                this._schoolName = tbl.Rows[0][1].ToString();
                this._shortName = tbl.Rows[0][2].ToString();
                this._address = tbl.Rows[0][3].ToString();
                this._phone = tbl.Rows[0][4].ToString();
                this._email = tbl.Rows[0][5].ToString();
                this._website = tbl.Rows[0][6].ToString();
                this.Logo = (byte[])tbl.Rows[0][7];
                this._establishedYear = tbl.Rows[0][8].ToString();
                this._slogan = tbl.Rows[0][9].ToString();
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
