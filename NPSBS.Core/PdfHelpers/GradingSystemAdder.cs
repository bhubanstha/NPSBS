using System;
using System.Collections.Generic;
using Education.Common.FontHelper;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace NPSBS.Core
{
    public class GradingSystemAdder
    {
        private static PdfPCell cell = null;
        private static ResultFont rf = StartupCache.ResultFont;
        static string gpa = Environment.NewLine + "Grade Point Average (GPA):________" + Environment.NewLine + Environment.NewLine + "                   Average Grade:_________" + Environment.NewLine + Environment.NewLine + "                Attendance: _____________";
        private static List<GradingSystem> grades = StartupCache.GradingSystem;

        public static PdfPTable AddGradingSystem(PdfPTable table, int classId, int leftColspan = 2, int rightColspan = 3, bool LeftBorderVisible = true)
        {
            cell = new PdfPCell();

            cell.AddElement(new Phrase(gpa, rf.GPAFont));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Colspan = leftColspan;            
            cell.Border = 0;
            table.AddCell(cell);


            PdfPTable gradeTable = GradingTable(table.TotalWidth - 180);
            cell = new PdfPCell();
            cell.AddElement(gradeTable);
            if (classId >= 11)
            {
                cell.PaddingLeft = -30;
            }
            cell.Border = 0;
            cell.Colspan = rightColspan;
            table.AddCell(cell);
            return table;
        }

        public static PdfPTable GradingTable(float width)
        {
            float[] cols = new float[] { 30F, 30F, 70F, 70F };
            PdfPTable gradeTable = new PdfPTable(4);
            gradeTable.TotalWidth = width;
            gradeTable.SetWidths(cols);
            gradeTable.LockedWidth = true;


            cell = new PdfPCell(new Phrase("Grading System", rf.GradingSystem));
            //cell.AddElement(new Phrase("Grading System", gradingFont));

            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            // cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Colspan = 4;
            gradeTable.AddCell(cell);

            //cell = new PdfPCell();
            //cell.AddElement(new Phrase("Letters Grades are used to show the academic standing of a student, with the following values, equivalent marks and remarks:", rf.GradingSystem));
            //cell.Colspan = 4;
            //cell.HorizontalAlignment = Element.ALIGN_CENTER;
            //gradeTable.AddCell(cell);


            cell = new PdfPCell();
            cell.AddElement(new Phrase("Grade", rf.GradingSystem));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            gradeTable.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Phrase("Grade Point", rf.GradingSystem));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            gradeTable.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Phrase("Equivalent Marks", rf.GradingSystem));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            gradeTable.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(new Phrase("Remarks", rf.GradingSystem));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;

            gradeTable.AddCell(cell);
            for (int i = 0; i < grades.Count; i++)
            {
                cell = new PdfPCell();
                cell.AddElement(new Phrase(grades[i].LetterGrade, rf.GradingSystem));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                gradeTable.AddCell(cell);

                cell = new PdfPCell();
                cell.AddElement(new Phrase(grades[i].MaxGradePoint.ToString(), rf.GradingSystem));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                gradeTable.AddCell(cell);

                cell = new PdfPCell();
                cell.AddElement(new Phrase(grades[i].EquivalentMarks, rf.GradingSystem));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                gradeTable.AddCell(cell);

                cell = new PdfPCell();
                cell.AddElement(new Phrase(grades[i].Remarks, rf.GradingSystem));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                gradeTable.AddCell(cell);
            }
            return gradeTable;
        }

        public static PdfPTable AttitudesAndHabits(float width, int studentId = 0, int ExaminationId = 0)
        {
            float[] cols = new float[] { 180F, 70F };
            PdfPTable aTable = new PdfPTable(2);
            aTable.TotalWidth = width;
            aTable.SetWidths(cols);
            aTable.LockedWidth = true;

            System.Data.DataTable tbl = AHTable(studentId, ExaminationId);
            PdfPCell cell;
            cell = new PdfPCell(new Phrase("Attitudes and Habits"));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Colspan = 2;
            aTable.AddCell(cell);
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                cell = new PdfPCell(new Phrase(tbl.Rows[i][0].ToString()));
                cell.MinimumHeight = 20;
                aTable.AddCell(cell);
                cell = new PdfPCell(new Phrase(tbl.Rows[i][1].ToString()));
                cell.MinimumHeight = 20;
                aTable.AddCell(cell);
            }
            return aTable;
        }

        private static System.Data.DataTable AHTable(int StudentId , int ExaminationId)
        {
            System.Data.DataTable record = new Exam().GetExtraActivities(StudentId, ExaminationId);
            System.Data.DataTable tbl = new System.Data.DataTable();
            tbl.Columns.Add("Key");
            tbl.Columns.Add("Value");
            int schoolDays = 0;
            int presentDays = 0;
            string drawing = "-", games = "-", conduct = "-", cleanliness = "-", cooperation = "-";
            if (record.Rows.Count > 0)
            {
                schoolDays = record.Rows[0]["SchoolDays"].ToString() == "" ? 0 : Convert.ToInt32(record.Rows[0]["SchoolDays"].ToString());
                presentDays = record.Rows[0]["PresentDays"].ToString() == "" ? 0 : Convert.ToInt32(record.Rows[0]["PresentDays"].ToString());
                drawing = record.Rows[0]["Drawing"].ToString();
                games = record.Rows[0]["Games"].ToString();
                conduct = record.Rows[0]["Conduct"].ToString();
                cleanliness = record.Rows[0]["PersonalCleanliness"].ToString();
                cooperation = record.Rows[0]["Cooperation"].ToString();
            }

            tbl.Rows.Add("School Day", schoolDays.ToString());
            tbl.Rows.Add("Present Day", presentDays.ToString());
            tbl.Rows.Add("Drawing", drawing);
            tbl.Rows.Add("Games", games);
            tbl.Rows.Add("Conduct", conduct);
            tbl.Rows.Add("Personal Cleanness", cleanliness);            
            tbl.Rows.Add("Co-operation", cooperation);
            record.Dispose();
            return tbl;
        }
    }
}
