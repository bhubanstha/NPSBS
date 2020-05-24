using Education.Common;
using Utility;

namespace NPSBS.Core
{
    public class Attendance
    {

        #region Private Fields
        private int _studentId;
        private int _classId;
        private int _examinationid;
        private int _schoolDays;
        private int _presentDays;
        private readonly DataAccess dataAccess;
        #endregion

        #region Properties
        public int StudentId {
            get { return _studentId; }
            set { 
                if(value<1)
                {
                    _studentId = 0;
                }
                _studentId = value;
                }
        }
        public int ClassId 
        {
            get { return _classId; }
            set
            {
                if (value < 1)
                {
                    _classId = 0;
                }
                _classId = value;
            }
        }
        public int ExaminationId 
        {
            get { return _examinationid; }
            set 
            {
                if (value < 1)
                {
                    _examinationid = 0;
                }
                _examinationid = value;
            }
        }
        public int ExamYear { get; set; }
        public int SchoolDays 
        {
            get { return _schoolDays; }
            set
            {
                if (value < 1)
                {
                    _schoolDays = 0;
                }
                _schoolDays = value;
            }
        }
        public int PresentDays 
        {
            get { return _presentDays; }
            set 
            {
                if (value < 1)
                {
                    _presentDays = 0;
                }
                _presentDays = value;
            }
        }

        public string RollNumber { get; set; }

        #endregion

        #region Constructor

        public Attendance()
        {
            dataAccess = new DataAccess(App.NPSBS);
        }

        #endregion
        public int SaveAttendance(Attendance attendance)
        {
            int i = 0;
            var cmd = dataAccess.CreateCommand();
            cmd.CommandText = "usp_SaveAttendance";
            cmd.Parameters.AddWithValue("@StudentId", attendance.StudentId);
            cmd.Parameters.AddWithValue("@RollNumber", attendance.RollNumber);
            cmd.Parameters.AddWithValue("@ClassId", attendance.ClassId);
            cmd.Parameters.AddWithValue("@ExaminationId", attendance.ExaminationId);
            cmd.Parameters.AddWithValue("@ExamHeldYear", attendance.ExamYear);
            cmd.Parameters.AddWithValue("@SchoolDays", attendance.SchoolDays);
            cmd.Parameters.AddWithValue("@PresentDays", attendance.PresentDays);
            i = dataAccess.ExecuteNonQuery(cmd);
            return i;
        }
    }
}
