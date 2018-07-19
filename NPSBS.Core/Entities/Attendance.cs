using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPSBS.Core
{
    public class Attendance
    {
        private int _studentId;
        private int _classId;
        private int _examinationid;
        private int _schoolDays;
        private int _presentDays;
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


        public int SaveAttendance(Attendance attendance)
        {
            int i = 0;
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_SaveAttendance";
            cmd.Parameters.AddWithValue("@StudentId", attendance.StudentId);
            cmd.Parameters.AddWithValue("@ClassId", attendance.ClassId);
            cmd.Parameters.AddWithValue("@ExaminationId", attendance.ExaminationId);
            cmd.Parameters.AddWithValue("@ExamHeldYear", attendance.ExamYear);
            cmd.Parameters.AddWithValue("@SchoolDays", attendance.SchoolDays);
            cmd.Parameters.AddWithValue("@PresentDays", attendance.PresentDays);
            i = DataAccess.ExecuteNonQuery(cmd);
            return i;
        }
    }
}
