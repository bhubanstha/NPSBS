using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Utility;

namespace Montessori.Core
{
    public class KidsZoneResult
    {
        private static FileStream fs = null;
        private static PdfContentByte contentByte = null;
        private static PdfWriter writer = null;
        private static ResultFont rf = StartupCache.ResultFont;
        //private static GradingSystem gs = new GradingSystem();
        static ColumnText ct = null;
        static Phrase phrase = null;
        static iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(Constant.MLogo);
        private static School _schoo;

        public static Document Publish(System.Data.DataSet result, string location, int examinationId, int classId, School school)
        {
            try
            {
                _schoo = school;
                fs = new FileStream(location, FileMode.Create, FileAccess.Write, FileShare.None);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            Document doc = new Document(PageSize.A4, 17F, 7F, 15F, 10F);
            writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            contentByte = writer.DirectContent;

            doc.AddTitle("National Peace Kids Zone Result");
            doc.AddSubject("Exam Result");
            doc.AddCreator("Result Processing System v. 1.0");
            doc.AddAuthor("Bhuban Shrestha +(977) 9843-13-6975)");
            WriteResult(doc, result, writer, contentByte, examinationId, classId);
            return doc;
        }

        private static Document WriteResult(Document doc, System.Data.DataSet result, PdfWriter writer, PdfContentByte contentByte, int examinationId, int classId)
        {
            for (int i = 0; i < result.Tables.Count; i++)
            {
                int sid = 0;
                int schoolDays = 0;
                int presentDay = 0;
                jpg.SetAbsolutePosition(18, 705);
                //jpg.SetAbsolutePosition(300, 300);
                jpg.ScalePercent(35);
                doc.Add(jpg);
                string studentName = result.Tables[i].Rows[0]["StudentFullName"].ToString();
                string className = result.Tables[i].Rows[0]["ClassName"].ToString();
                string rollNumber = result.Tables[i].Rows[0]["RollNumber"].ToString();
                string examName = result.Tables[i].Rows[0]["ExamName"].ToString();
                string examYear = result.Tables[i].Rows[0]["ExamHeldYear"].ToString();
                string remarks = result.Tables[i].Rows[0]["Remarks"].ToString();
                DateTime printDate = Convert.ToString(result.Tables[i].Rows[0]["ResultPrintDate"]) == "" ? DateTime.Now : Convert.ToDateTime(result.Tables[i].Rows[0]["ResultPrintDate"].ToString());
                Header(doc, examName, examYear, printDate);
                doc.Add(Marksheet(doc.PageSize.Width - 35, result.Tables[i], remarks, out sid));
                doc.Add(ExtraActivities(doc.PageSize.Width - 35, examinationId, classId, sid));

                ct = new ColumnText(contentByte);
                phrase = new Phrase(studentName, rf.StudentName);
                ct.SetSimpleColumn(phrase, 70, 675, 1300, 300, 15, Element.ALIGN_LEFT);
                ct.Go();

                ct = new ColumnText(contentByte);
                phrase = new Phrase(className, rf.StudentName);
                ct.SetSimpleColumn(phrase, 90, 655, 1300, 300, 15, Element.ALIGN_LEFT);
                ct.Go();

                ct = new ColumnText(contentByte);
                phrase = new Phrase(rollNumber, rf.StudentName);
                ct.SetSimpleColumn(phrase, 490, 655, 1300, 300, 15, Element.ALIGN_LEFT);
                ct.Go();

                doc.NewPage();
            }


            return doc;
        }

        private static void Header(Document doc, string examName, string examYear, DateTime examDate)
        {
            contentByte.Rectangle(10, doc.PageSize.Height - 10, doc.PageSize.Width - 20, (-doc.PageSize.Height) + 20);
            contentByte.Stroke(); //left outer rectangle

            contentByte.Rectangle(13, doc.PageSize.Height - 13, doc.PageSize.Width - 26, (-doc.PageSize.Height) + 26);
            contentByte.Stroke(); //left inner rectangle

            PdfPTable table = new PdfPTable(2);
            table.TotalWidth = doc.PageSize.Width - 35;
            table.LockedWidth = true;
            table.HorizontalAlignment = Element.ALIGN_LEFT;

            PdfPCell cell;
            cell = new PdfPCell(new Phrase(_schoo.SchoolName, rf.SchoolName));
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = Rectangle.NO_BORDER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("(Affiliated to National Peace Secondary Boarding School)", rf.SchoolAddress));
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = Rectangle.NO_BORDER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(_schoo.Address, rf.SchoolAddress));
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = Rectangle.NO_BORDER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Estd: " + _schoo.EstiblishedYear, rf.SchoolAddress));
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = Rectangle.NO_BORDER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Phone No.: " + _schoo.PhoneNo, rf.SchoolPhone));
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = Rectangle.NO_BORDER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(examName + ", " + examYear, rf.ExamName));
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = Rectangle.NO_BORDER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("PROGRESS REPORT", rf.GradeSheet));
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = Rectangle.NO_BORDER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Name:_________________________________________________________________________", rf.SchoolAddress));
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.FixedHeight = 35;
            cell.VerticalAlignment = Element.ALIGN_BOTTOM;
            cell.Border = Rectangle.NO_BORDER;

            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Standard:______________________", rf.SchoolAddress));
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.FixedHeight = 20;
            cell.VerticalAlignment = Element.ALIGN_BOTTOM;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Roll Number:______________", rf.SchoolAddress));
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            cell.FixedHeight = 20;
            cell.VerticalAlignment = Element.ALIGN_BOTTOM;
            table.AddCell(cell);

            ct = new ColumnText(contentByte);
            phrase = new Phrase("Date: " + examDate.ToString("yyyy/MM/dd"), rf.ResultDate);
            ct.SetSimpleColumn(phrase, 700, 710, 450, 30, 15, Element.ALIGN_LEFT);
            ct.Go();

            doc.Add(table);
        }

        private static PdfPTable Marksheet(float width, System.Data.DataTable tbl, string remarks, out int StudentId)
        {
            StudentId = tbl.Rows[0]["StudentId"].ToString() == "" ? 0 : Convert.ToInt32(tbl.Rows[0]["StudentId"].ToString());
            PdfPTable table = new PdfPTable(4);
            table.TotalWidth = width;
            table.SetWidths(new float[] { 25F, 150F, 60F, 200f });
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            table.SpacingBefore = 5;
            table.LockedWidth = true;

            PdfPCell cell;

            cell = new PdfPCell(new Phrase("S.N", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Subject", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Grade", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Remarks", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                cell = new PdfPCell(new Phrase((i + 1).ToString(), rf.Subject));
                cell.PaddingLeft = 5;
                cell.FixedHeight = 17;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(tbl.Rows[i]["SubjectName"].ToString(), rf.Subject));
                cell.PaddingLeft = 5;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(tbl.Rows[i]["ObtainedGrade"].ToString(), rf.Subject));
                cell.PaddingLeft = 5;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                if (i == 0)
                {
                    cell = new PdfPCell(new Phrase(remarks));
                    cell.Rowspan = 9;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                }

            }
            return table;
        }

        private static PdfPTable ExtraActivities(float width, int examinationId, int classId, int studentId)
        {
            int schoolDays, presentDay;
            PdfPTable table = new PdfPTable(3);
            table.TotalWidth = width;
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            table.SetWidths(new float[] { 200F, 30F, 150F });
            table.LockedWidth = true;

            PdfPCell cell;

            cell = new PdfPCell();
            cell.AddElement(GetExtraActivities(width / 2 - 10, examinationId, studentId, out schoolDays, out presentDay));
            table.AddCell(cell);

            cell = new PdfPCell();
            table.AddCell(cell);

            cell = new PdfPCell();
            cell.AddElement(Grades(schoolDays, presentDay));
            float w = cell.Width;
            table.AddCell(cell);

            return table;
        }


        private static PdfPTable GetExtraActivities(float width, int ExaminationId, int StudentId, out int schoolDays, out int presentDays)
        {
            rf.SchoolPhone.Size = 12;
            System.Data.DataTable tbl = Montessori.Core.ExtraActivities.GetStudentActivities(StudentId, ExaminationId);
            PdfPTable table = new PdfPTable(2);
            table.TotalWidth = width + 25;
            table.SetWidths(new float[] { width - 80, 80f });
            table.LockedWidth = true;
            PdfPCell cell1, cell2;
            cell1 = new PdfPCell(new Phrase("Co-Curricular Activities", rf.Arial));
            cell1.Colspan = 2;
            cell1.BorderWidthTop = 0;
            cell1.FixedHeight = 25;
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell1);
            for (int i = 0; i < tbl.Columns.Count - 2; i++)
            {
                string txt = tbl.Columns[i].ColumnName;
                string val = tbl.Rows[0][i].ToString();
                cell2 = new PdfPCell();
                if (i == 0 || i == 5 || i == 11 || i == 17)
                {
                    cell1 = new PdfPCell(new Phrase(txt, rf.SchoolPhone));
                }
                else
                {
                    cell1 = new PdfPCell(new Phrase(txt, rf.Marks));
                }
                if (i == 16) //Height and weight
                {
                    if (val.Length > 0 && val.ToLower().Contains('f'))
                    {
                        string[] values = val.ToLower().Split('f');
                        Chunk ftChunk = new Chunk("ft", rf.Small);
                        ftChunk.SetTextRise(4);
                        Paragraph p = new Paragraph("", rf.Marks);
                        p.Add(values[0].Trim());
                        p.Add(ftChunk);
                        p.Add(" " + values[1].ToUpper());
                        cell2 = new PdfPCell(new Phrase(p));
                    }
                    else
                    {
                        cell2 = new PdfPCell(new Phrase(val, rf.Marks));
                    }
                }
                else if(i==12)
                {
                    cell2 = new PdfPCell(new Phrase(val.ToSentenceCase(), rf.Marks));
                }
                else
                {
                    cell2 = new PdfPCell(new Phrase(val, rf.Marks));
                }

                cell1.FixedHeight = 20;
                cell2.FixedHeight = 20;
                cell1.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
                if (i == tbl.Columns.Count - 3)
                {
                    cell1.BorderWidthBottom = 0;
                    cell2.BorderWidthBottom = 0;
                }

                table.AddCell(cell1);
                table.AddCell(cell2);
            }
            schoolDays = tbl.Rows[0]["SchoolDays"].ToString() == "" ? 0 : Convert.ToInt32(tbl.Rows[0]["SchoolDays"].ToString());
            presentDays = tbl.Rows[0]["Present_Days"].ToString() == "" ? 0 : Convert.ToInt32(tbl.Rows[0]["Present_Days"].ToString());
            return table;
        }

        private static PdfPTable Grades(int schoolDays, int presentDays)
        {
            rf.GradingSystem.Size = 12;
            PdfPTable table = new PdfPTable(2);
            table.TotalWidth = 221;
            table.SetWidths(new float[] { 120f, 100f });
            table.LockedWidth = true;
            PdfPCell cell;

            cell = new PdfPCell(new Phrase("Grade Explanation", rf.Arial));
            cell.Colspan = 2;
            cell.FixedHeight = 25;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidthTop = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("A+: Excellent", rf.GradingSystem));
            cell.Colspan = 2;
            cell.FixedHeight = 25;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("A: Very good", rf.GradingSystem));
            cell.Colspan = 2;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.FixedHeight = 25;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("B: Good", rf.GradingSystem));
            cell.Colspan = 2;
            cell.FixedHeight = 25;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("C: Satisfactory", rf.GradingSystem));
            cell.Colspan = 2;
            cell.FixedHeight = 25;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("D: Weak, Needs improvement", rf.GradingSystem));
            cell.Colspan = 2;
            cell.FixedHeight = 25;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);


            cell = new PdfPCell(new Phrase("Attendance Record", rf.Arial));
            cell.Colspan = 2;
            cell.FixedHeight = 70;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("a) Working Days"));
            cell.FixedHeight = 25;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(schoolDays.ToString()));
            cell.FixedHeight = 25;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("b) Present Days"));
            cell.FixedHeight = 25;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(presentDays.ToString()));
            cell.FixedHeight = 25;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(""));
            cell.Colspan = 2;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Sign of Director"));
            cell.FixedHeight = 59;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(""));
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Sign of Class Teacher"));
            cell.FixedHeight = 59;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(""));
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Sign of Parents"));
            cell.FixedHeight = 59;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.BorderWidthBottom = 0;

            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(""));
            cell.BorderWidthBottom = 0;
            table.AddCell(cell);
            return table;
        }
    }
}
