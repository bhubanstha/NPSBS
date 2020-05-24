using System.Collections.Generic;

namespace NPSBS.Core
{
    public class StudentResult
    {
        public string ExamName { get; set; }
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public string RollNumber { get; set; }

        public StudentResult()
        {
           
        }

        public StudentResult GetResult()
        {
            StudentResult r = new StudentResult();
            r.ExamName = "First Terminal Exam, 2072";
            r.StudentName = "Bhuban Shrestha";
            r.ClassName = "X";
            r.RollNumber = "1";
            return r;
        }
    }

    public class Result
    {
        public int SN { get; set; }
        public string Subject { get; set; }
        public decimal ObtainTheory { get; set; }
        public decimal ObtainPractical { get; set; }
        public decimal ObtainTotal { get; set; }

        public string TheoryGrade { get; set; }
        public string PracticalGrade { get; set; }
        public string TotalGrade { get; set; }

        public string GPA { get; set; }
        public string AverageGrade { get; set; }
        public string ResultPrintDate { get; set; }
        public StudentResult studentRes { get; set; }
        

        public List<Result> GetResult()
        {
            List<Result> res = new List<Result>();
            res.Add(new Result
            {
                SN = 1,
                Subject = "English",
                ObtainTheory = 70,
                ObtainPractical = 20,
                ObtainTotal = ObtainTheory + ObtainPractical,
                TheoryGrade = "A",
                PracticalGrade = "A",
                TotalGrade = "A",
                GPA = "3.5",
                AverageGrade = "A",
                ResultPrintDate = "2072/03/21"
            });
            res.Add(new Result
            {
                SN = 2,
                Subject = "Mathematics",
                ObtainTheory = 74,
                ObtainPractical = 20,
                ObtainTotal = ObtainTheory + ObtainPractical,
                TheoryGrade = "A",
                PracticalGrade = "A",
                TotalGrade = "A",
                GPA = "3.5",
                AverageGrade = "A",
                ResultPrintDate = "2072/03/21"
            });
            res.Add(new Result
            {
                SN = 3,
                Subject = "Science",
                ObtainTheory = 55,
                ObtainPractical = 20,
                ObtainTotal = ObtainTheory + ObtainPractical,
                TheoryGrade = "A",
                PracticalGrade = "A",
                TotalGrade = "A",
                GPA = "3.5",
                AverageGrade = "A",
                ResultPrintDate = "2072/03/21"
            });

            return res;
        }
    }

}
