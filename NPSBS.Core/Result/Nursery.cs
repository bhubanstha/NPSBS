using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Utility;

namespace NPSBS.Core
{
    public class Nursery
    {
        private static FileStream fs = null;
        private static PdfContentByte contentByte = null;
        private static PdfWriter writer = null;
        private static ResultFont rf = StartupCache.ResultFont;
        private static GradingSystem gs = new GradingSystem();
        static ColumnText ct = null;
        static Phrase phrase = null;
        private static School _school;
        static iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(Constant.NPSBSLogo);
        public static Document Publish(string location, System.Data.DataSet result, int examinationId, int classId, School school)
        {
            try
            {
                _school = school;
                fs = new FileStream(location, FileMode.Create, FileAccess.Write, FileShare.None);
            }
            catch (Exception ex)
            {

                throw ex;
            }


            Document doc = new Document(PageSize.A4, 15F, 15F, 45F, 7F); ;


            writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            contentByte = writer.DirectContent;

            doc.AddTitle("Result");
            doc.AddSubject("Exam Result");
            doc.AddCreator("iTextSharp");
            doc.AddAuthor("Bhuban Shrestha");
            //Header.WriteHeader(doc, fs, out contentByte);
            WriteResult(doc, result, writer, contentByte, examinationId, classId);
            return doc;
        }

        private static void WriteResult(Document doc, System.Data.DataSet ds, PdfWriter _writer, PdfContentByte _contentByte, int ExaminationId, int classId)
        {
            int studentId = 0;
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                //from left, from bottom, width, height
                contentByte.Rectangle(10, doc.PageSize.Height - 10, doc.PageSize.Width - 20, (-doc.PageSize.Height) + 20);
                contentByte.Stroke(); //left outer rectangle

                contentByte.Rectangle(13, doc.PageSize.Height - 13, doc.PageSize.Width - 26, (-doc.PageSize.Height) + 26);
                contentByte.Stroke(); //left inner rectangle

                DateTime printDate = Convert.ToDateTime(ds.Tables[i].Rows[0]["ResultPrintDate"]);
                string examName = ds.Tables[i].Rows[0]["ExamName"].ToString();
                string studentName = ds.Tables[i].Rows[0]["StudentFullName"].ToString();
                string rollNumber = ds.Tables[i].Rows[0]["RollNumber"].ToString();
                studentId = Convert.ToInt32(ds.Tables[i].Rows[0]["StudentId"]);
                PdfPTable pdfTable = new PdfPTable(7);

                pdfTable.TotalWidth = doc.PageSize.Width-80;
                pdfTable.LockedWidth = true;
                pdfTable.SetWidths(new float[] { 20, 130, 50, 50, 50, 50, 100 });

               


                DocumentHeader(doc, examName, printDate, studentName, rollNumber);

                //Header.LeftHeader(doc, fs, _writer, _contentByte, printDate, examName);
                ct = new ColumnText(contentByte);
                phrase = new Phrase(studentName, rf.StudentName);
                ct.SetSimpleColumn(phrase, 142, 658, 1300, 300, 15, Element.ALIGN_LEFT);
                ct.Go();

                ct = new ColumnText(contentByte);
                phrase = new Phrase(rollNumber, rf.StudentName);
                ct.SetSimpleColumn(phrase, 512, 628, 800, 300, 15, Element.ALIGN_LEFT);
                ct.Go();

                PdfPCell cell=new PdfPCell();
                TableHeader(pdfTable, cell);

                decimal totalObtained = 0;
                decimal fullMark = 0;
                decimal obtainGPA = 0;
                int subjectCount = 0;
                for (int j = 0; j < ds.Tables[i].Rows.Count; j++)
                {
                    subjectCount++;
                    decimal obtainTheory =  Convert.ToDecimal(ds.Tables[i].Rows[j]["ObtainedTheory"].ToString());
                    decimal obtainPractical = Convert.ToDecimal(ds.Tables[i].Rows[j]["ObtainedPractical"].ToString());
                    decimal TotalTheory = Convert.ToDecimal(ds.Tables[i].Rows[j]["TheoryMarks"].ToString());
                    decimal TotalPractial =  Convert.ToDecimal(ds.Tables[i].Rows[j]["PracticalMarks"].ToString());
                    totalObtained = (obtainTheory + obtainPractical);
                    fullMark = (TotalTheory + TotalPractial);

                    cell = new PdfPCell(new Phrase((j + 1).ToString()));
                    cell.MinimumHeight = 35;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    pdfTable.AddCell(cell);

                    string test = ((obtainTheory+obtainPractical)/(TotalTheory+TotalPractial)).ToString();

                    string subject = ds.Tables[i].Rows[j]["SubjectName"].ToString();
                    if (subject.ToLower() == "conversation") subject += Environment.NewLine + "Nursery Rhymes";
                    else subject += Environment.NewLine + "(Written + Oral)";

                    cell = new PdfPCell(new Phrase(subject));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    pdfTable.AddCell(cell);

                    cell = new PdfPCell(new Phrase(gs.ObtainGrade(obtainTheory, TotalTheory)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    pdfTable.AddCell(cell);

                    cell = new PdfPCell(new Phrase( gs.ObtainGrade(obtainPractical, TotalPractial)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    pdfTable.AddCell(cell);

                   
                    cell = new PdfPCell(new Phrase(gs.ObtainGrade(obtainTheory + obtainPractical, TotalTheory + TotalPractial)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    pdfTable.AddCell(cell);

                    var gpa = gs.ObtainGradePoint(totalObtained, fullMark);
                    obtainGPA += gpa;                  
                   
                    cell = new PdfPCell(new Phrase(gpa.ToString()));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    pdfTable.AddCell(cell);

                    if (j == 0)
                    {
                        cell = new PdfPCell(new Phrase(""));
                        cell.Rowspan = ds.Tables[i].Rows.Count;
                        pdfTable.AddCell(cell);
                    }

                }

                PdfPTable tAt = GradingSystemAdder.AttitudesAndHabits(227, studentId, ExaminationId);
                PdfPTable tGs = GradingSystemAdder.GradingTable(285);

                cell = new PdfPCell();
                cell.Colspan = 3;
                cell.Border = Rectangle.NO_BORDER;
                cell.AddElement(tAt);
                pdfTable.AddCell(cell);

                cell = new PdfPCell();
                cell.Colspan = 4;
                cell.Rowspan = 2;
                cell.Border = Rectangle.NO_BORDER;
                cell.AddElement(tGs);
                pdfTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(Environment.NewLine + Environment.NewLine + "Grade Point Average (GPA): _________" + Environment.NewLine + Environment.NewLine + "                   Average Grade : _________" + Environment.NewLine + Environment.NewLine));
                cell.Colspan = 3;
                pdfTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + "Class Teacher Signature ____________________"));
                cell.Colspan = 6;
                cell.Border = Rectangle.NO_BORDER;
                pdfTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(Environment.NewLine + Environment.NewLine + Environment.NewLine  + Environment.NewLine + "________________" + Environment.NewLine + "School Seal"));
                cell.Colspan = 1;
                cell.Border = Rectangle.NO_BORDER;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(Environment.NewLine + Environment.NewLine + "Principal Signature _________________________"));
                cell.Colspan = 7;
                cell.Border = Rectangle.NO_BORDER;
                pdfTable.AddCell(cell);

               

                
                decimal subjectGpa = gs.GPA(obtainGPA, subjectCount);
                string averageGrade = gs.AverageGrade(subjectGpa);

                ct = new ColumnText(contentByte);
                phrase = new Phrase(subjectGpa.ToString("N"));
                ct.SetSimpleColumn(phrase, 200, 220, 450, 30, 15, Element.ALIGN_LEFT);
                ct.Go();

                ct = new ColumnText(contentByte);
                phrase = new Phrase(averageGrade);
                ct.SetSimpleColumn(phrase, 200, 196, 450, 30, 15, Element.ALIGN_LEFT);
                ct.Go();                
                doc.Add(pdfTable);

                PdfPTable tRe = new PdfPTable(1);
                //tRe.DefaultCell.Border = Rectangle.NO_BORDER;
                //tRe.DefaultCell.BorderColor = BaseColor.WHITE;
                tRe.DefaultCell.FixedHeight = 100f;
                tRe.TotalWidth = 80;
                tRe.LockedWidth = true;
                tRe.SetWidths(new float[] { 80 });
                tRe = Header.WriteRemarks(subjectGpa, tRe, classId);
                tRe.WriteSelectedRows(0, -1, doc.PageSize.Width - 150, 515, contentByte);

                doc.NewPage();
            }
        }

        private static void DocumentHeader(Document doc, string examName, DateTime resultDate, string studentName, string rollNumber)
        {
            jpg.SetAbsolutePosition(38, 675);
            jpg.ScalePercent(40);
            doc.Add(jpg);

            PdfPTable table = new PdfPTable(3);
            table.TotalWidth = doc.PageSize.Width - 80;
            table.LockedWidth = true;
            float width = doc.PageSize.Width / 3;
            table.SetWidths(new float[] { 100, width, width });
            table.DefaultCell.Border = Rectangle.NO_BORDER;
            table.DefaultCell.BorderColor = BaseColor.WHITE;

            PdfPCell cell;
            cell = new PdfPCell(new Phrase(_school.SchoolName, rf.NurserySchool));
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Colspan = 3;
            table.AddCell(cell);

            //cell = new PdfPCell(new Phrase("School Logo"));
            //cell.Rowspan = 6;
            //cell.Border = Rectangle.NO_BORDER;
            //cell.HorizontalAlignment = Element.ALIGN_CENTER;
            //cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            //table.AddCell(cell);

            cell = new PdfPCell(new Phrase(_school.Address, rf.SchoolAddress));
            cell.Colspan = 3;
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("ESTD " + _school.EstiblishedYear, rf.SchoolAddress));
            cell.Colspan = 3;
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Phone: " + _school.PhoneNo, rf.SchoolPhone));
            cell.Colspan = 3;
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(_school.Slogan, rf.Arial));
            cell.Colspan = 3;
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(examName + ", " + resultDate.Year, rf.ExamName));
            cell.Colspan = 3;
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Date: " + resultDate.ToString("yyyy/MM/dd"), rf.ResultDate));
            cell.Colspan = 3;
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Name of Student: ............................................................................................................................"));
            cell.Colspan = 3;
            cell.Border = Rectangle.NO_BORDER;
            cell.MinimumHeight = 30;
            cell.VerticalAlignment = Element.ALIGN_BOTTOM;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Class: Nursery"));
            cell.Border = Rectangle.NO_BORDER;
            cell.MinimumHeight = 20;
            cell.VerticalAlignment = Element.ALIGN_BOTTOM;
            table.AddCell(cell);

            //cell = new PdfPCell(new Phrase("       Section: .............."));
            cell = new PdfPCell(new Phrase(""));
            cell.Border = Rectangle.NO_BORDER;
            cell.MinimumHeight = 30;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_BOTTOM;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Roll No: ............."));
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            cell.VerticalAlignment = Element.ALIGN_BOTTOM;
            cell.MinimumHeight = 20;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("GRADE-SHEET", rf.StatementOfMark));
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_TOP;
            cell.Colspan = 3;
            cell.MinimumHeight = 40;
            table.AddCell(cell);

            /*
            cell = new PdfPCell();
            cell = GetCell("Phone: 4-353212, 4-380292", 2,0);
            table.AddCell(cell);

            cell = new PdfPCell();
            cell = GetCell("An English Medium Co-Educational Boarding/Day School", 2,0);
            table.AddCell(cell);

            cell = new PdfPCell();
            cell = GetCell(examName + " for " + resultDate.Year, 2,0);
            table.AddCell(cell);

            cell = new PdfPCell();
            cell = GetCell("Date: " + resultDate.ToString("yyyy/MM/dd"), 2,0);
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            table.AddCell(cell);
            /*

                      cell = GetCell("Student............................................................................", 3, 0); 
                      cell.HorizontalAlignment = Element.ALIGN_LEFT;
                      table.AddCell(cell);

                      cell = GetCell("Class: Nursery", 0, 0);
                      cell.HorizontalAlignment = Element.ALIGN_LEFT;
                      table.AddCell(cell);

                      cell = GetCell("Section: ....................", 0, 0); 
                      cell.HorizontalAlignment = Element.ALIGN_LEFT;
                      table.AddCell(cell);

                      cell = GetCell("Roll No.  ....................", 0, 0); 
                      cell.HorizontalAlignment = Element.ALIGN_LEFT;
                      table.AddCell(cell);
                       * */
            doc.Add(table);
        }

        private static void TableHeader(PdfPTable pdfTable, PdfPCell cell)
        {

            cell = new PdfPCell(new Phrase("S.N.", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Rowspan = 2;
            pdfTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Subjects", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Rowspan = 2;
            pdfTable.AddCell(cell);


            cell = new PdfPCell(new Phrase("Obtained Grade", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Colspan = 2;
            pdfTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Final Grade", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Rowspan = 2;
            pdfTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Grade Point", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Rowspan = 2;
            pdfTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Remarks", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Rowspan = 2;
            pdfTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Written", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Oral", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfTable.AddCell(cell);

           

        }
        private static PdfPCell GetCell(string cellText, int colspan = 0, int rowspan = 0)
        {
            PdfPCell cell;
            cell = new PdfPCell(new Phrase(cellText));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Colspan = colspan;
            cell.Rowspan = rowspan;
            return cell;
        }

        private static PdfPTable TableFooter(PdfPTable table)
        {

            PdfPTable tableHabbit = new PdfPTable(2);
            tableHabbit.TotalWidth = 100;
            tableHabbit.LockedWidth = true;
            tableHabbit.SetWidths(new float[] { 90F, 10F });

            PdfPCell cell;
            cell = new PdfPCell();
            cell.Rowspan = 2;
            cell.Colspan = 3;
            cell.AddElement(tableHabbit);
            table.AddCell(cell);

            PdfPTable tableGs = GradingSystemAdder.GradingTable(300);
            cell = new PdfPCell();
            cell.Colspan = 4;
            cell.AddElement(tableGs);
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(Environment.NewLine + "Grade Point Average (GPA): _______________" + Environment.NewLine + Environment.NewLine + "Average Grade: ____________"));
            table.AddCell(cell);
            return table;
        }
    }
}