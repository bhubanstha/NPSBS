using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace NPSBS.Core
{
    public class Header
    {
        static ResultFont rf = StartupCache.ResultFont;
        static iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(AppDomain.CurrentDomain.BaseDirectory + "\\logo.png");

        static ColumnText ct = null;
        static Phrase phrase = null;

        private static string School = "NATIONAL PEACE SECONDARY BOARDING SCHOOL";
        private static string Address = "Gongabu, Kathmandu, Nepal (ESTD. -1996)";
        private static string Phone = "Phone NO. :- 4-35-32-12";
        private static string ExamName = "Annual Exam, 2072";
        private static string GradeSheet = "GRADE-SHEET";

        private static List<GradingSystem> grades = new GradingSystem().GradingInfo();


        public static void RightHeader(Document doc, FileStream fs, PdfWriter writer, PdfContentByte contentByte, string printDate, string examName)
        {
            contentByte.Rectangle(doc.PageSize.Width / 2 + 7, doc.PageSize.Height - 10, doc.PageSize.Width / 2 - 20, (-doc.PageSize.Height) + 20);
            contentByte.Stroke();//right outer rectangle

            contentByte.Rectangle(doc.PageSize.Width / 2 + 10, doc.PageSize.Height - 13, doc.PageSize.Width / 2 - 26, (-doc.PageSize.Height) + 26);
            contentByte.Stroke();//right inner rectangle

            jpg.SetAbsolutePosition(doc.PageSize.Width / 2 + 20, doc.PageSize.Height - 105);
            jpg.ScalePercent(40);
            doc.Add(jpg);


            float start = doc.PageSize.Width / 2 + 120;
            ct = new ColumnText(contentByte);
            phrase = new Phrase("NATIONAL PEACE SECONDARY BOARDING SCHOOL", rf.SchoolName);
            ct.SetSimpleColumn(phrase, 506, 580, 820, 300, 15, Element.ALIGN_CENTER);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("Gongabu, Kathmandu, Nepal (ESTD.- 1996)", rf.SchoolAddress);
            ct.SetSimpleColumn(phrase, 505, 565, 815, 300, 15, Element.ALIGN_CENTER);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("Phone No. :- 4-35-32-12", rf.SchoolPhone);
            ct.SetSimpleColumn(phrase, 507, 550, 810, 300, 15, Element.ALIGN_CENTER);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase(examName, rf.ExamName);
            ct.SetSimpleColumn(phrase, 507, 530, 810, 300, 15, Element.ALIGN_CENTER);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("GRADE-SHEET", rf.GradeSheet);
            ct.SetSimpleColumn(phrase, 507, 510, 810, 300, 15, Element.ALIGN_CENTER);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase(printDate, rf.ResultDate);
            ct.SetSimpleColumn(phrase, 507, 495, 810, 200, 15, Element.ALIGN_RIGHT);
            ct.Go();


            ct = new ColumnText(contentByte);
            phrase = new Phrase("Name of Student:__________________________________________", rf.NameofStudent);
            ct.SetSimpleColumn(phrase, 440, 480, 850, 300, 15, Element.ALIGN_LEFT);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("Class:______________", rf.StudentClass);
            ct.SetSimpleColumn(phrase, 440, 455, 850, 300, 15, Element.ALIGN_LEFT);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("Roll No:____________", rf.StudentRollNumber);
            ct.SetSimpleColumn(phrase, 440 + 250, 455, 850, 300, 15, Element.ALIGN_LEFT);
            ct.Go();
            
            ct = new ColumnText(contentByte);
            phrase = new Phrase("________________" + Environment.NewLine + "     School Seal", rf.Arial);
            ct.SetSimpleColumn(phrase, 440, 30, 850, 60, 15, Element.ALIGN_LEFT);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("______________" + Environment.NewLine + "  Class Teacher", rf.Arial);
            ct.SetSimpleColumn(phrase, 580, 30, 850, 60, 15, Element.ALIGN_LEFT);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("____________" + Environment.NewLine + "      Principal", rf.Arial);
            ct.SetSimpleColumn(phrase, 738, 30, 850, 60, 15, Element.ALIGN_LEFT);
            ct.Go();

        }


        public static void LeftHeader(Document doc, FileStream fs, PdfWriter writer, PdfContentByte contentByte, string printDate, string examName)
        {
            //from left, from bottom, width, height
            contentByte.Rectangle(10, doc.PageSize.Height - 10, doc.PageSize.Width / 2 - 18, (-doc.PageSize.Height) + 20);
            contentByte.Stroke(); //left outer rectangle

            contentByte.Rectangle(13, doc.PageSize.Height - 13, doc.PageSize.Width / 2 - 24, (-doc.PageSize.Height) + 26);
            contentByte.Stroke(); //left inner rectangle

            ct = new ColumnText(contentByte);
            phrase = new Phrase("________________" + Environment.NewLine + "     School Seal", rf.Arial);
            ct.SetSimpleColumn(phrase, 22, 60, 450, 30, 15, Element.ALIGN_LEFT);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("______________" + Environment.NewLine + "  Class Teacher", rf.Arial);
            ct.SetSimpleColumn(phrase, 165, 60, 450, 30, 15, Element.ALIGN_LEFT);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("____________" + Environment.NewLine + "      Principal", rf.Arial);
            ct.SetSimpleColumn(phrase, 305, 60, 450, 30, 15, Element.ALIGN_LEFT);
            ct.Go();


            ct = new ColumnText(contentByte);
            phrase = new Phrase("NATIONAL PEACE SECONDARY BOARDING SCHOOL", rf.SchoolName);
            ct.SetSimpleColumn(phrase, 50, 580, 450, 300, 15, Element.ALIGN_CENTER);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("Gongabu, Kathmandu, Nepal (ESTD.- 1996)", rf.SchoolAddress);
            ct.SetSimpleColumn(phrase, 50, 565, 450, 300, 15, Element.ALIGN_CENTER);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("Phone No. :- 4-35-32-12", rf.SchoolPhone);
            ct.SetSimpleColumn(phrase, 50, 550, 450, 300, 15, Element.ALIGN_CENTER);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase(examName, rf.ExamName);
            ct.SetSimpleColumn(phrase, 50, 530, 450, 300, 15, Element.ALIGN_CENTER);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("GRADE-SHEET", rf.GradeSheet);
            ct.SetSimpleColumn(phrase, 50, 510, 450, 300, 15, Element.ALIGN_CENTER);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase(printDate, rf.ResultDate);
            ct.SetSimpleColumn(phrase, 50, 495, 400, 200, 15, Element.ALIGN_RIGHT);
            ct.Go();


            ct = new ColumnText(contentByte);
            phrase = new Phrase("Name of Student:____________________________________________", rf.NameofStudent);
            ct.SetSimpleColumn(phrase, 15, 480, 500, 300, 15, Element.ALIGN_LEFT);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("Class:______________", rf.StudentClass);
            ct.SetSimpleColumn(phrase, 15, 455, 500, 300, 15, Element.ALIGN_LEFT);
            ct.Go();

            ct = new ColumnText(contentByte);
            phrase = new Phrase("Roll No:____________", rf.StudentRollNumber);
            ct.SetSimpleColumn(phrase, 279, 455, 500, 300, 15, Element.ALIGN_LEFT);
            ct.Go();


            jpg.SetAbsolutePosition(20, doc.PageSize.Height - 105);
            jpg.ScalePercent(40);
            doc.Add(jpg);
        }

        public static PdfPTable WriteRemarks(decimal gpa, PdfPTable table, int classId)
        {
            table.DefaultCell.Border = Rectangle.NO_BORDER;
            string remarks = new GradingSystem().GradeRemarks(gpa);
            PdfPCell cell = new PdfPCell(new Phrase(remarks));

            cell.Border = Rectangle.NO_BORDER;
            cell.BorderColor = BaseColor.WHITE;
            if (classId == 2 || classId == 3 || classId == 4 || classId == 5)
            {
                cell.FixedHeight = 75;
                cell.Rotation = 0;
            }
            else
            {
                cell.FixedHeight = 100;
                cell.Rotation = -270;
            }
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);
           
            return table;
        }
    }
}
