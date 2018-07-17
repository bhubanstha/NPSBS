using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Montessori.Core
{
    public class pdfExtension
    {
        private static FileStream fs = null;
        private static PdfContentByte contentByte = null;
        private static PdfWriter writer = null;
        private static ResultFont rf = StartupCache.ResultFont;
        private static GradingSystem gs = new GradingSystem();
        static ColumnText ct = null;
        static Phrase phrase = null;


        /// <summary>
        /// Create new pdf document and open for writing.
        /// You have to close manually
        /// </summary>
        /// <param name="rotate"></param>
        /// <param name="location"></param>
        /// <returns></returns>
        public static Document CreateDocument(bool rotate, string location, System.Data.DataSet result, int classId)
        {
            try
            {
                fs = new FileStream(location, FileMode.Create, FileAccess.Write, FileShare.None);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            

            Document doc = null;
            if (rotate)
            {
                doc = new Document(PageSize.A4.Rotate(), 3F, 3F, 7F, 7F);
            }
            else
            {
                doc = new Document(PageSize.A4, 7F, 7F, 7F, 7F);
            }

            writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            contentByte = writer.DirectContent;

            doc.AddTitle("Result");
            doc.AddSubject("Exam Result");
            doc.AddCreator("iTextSharp");
            doc.AddAuthor("Bhuban Shrestha");
            //Header.WriteHeader(doc, fs, out contentByte);
            ClassKGTo7(result, doc, writer, contentByte, classId);
            return doc;
        }


        public static void ClassKGTo7(System.Data.DataSet ds, Document doc, PdfWriter _writer, PdfContentByte _contentByte, int classId)
        {
            int totalTable = ds.Tables.Count;
            bool isEven = totalTable % 2 == 0 ? true : false;
            
                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    string printDate ="Date: " +  Convert.ToDateTime(ds.Tables[i].Rows[0]["ResultPrintDate"]).ToString("yyyy/MM/dd");
                    string examName = ds.Tables[i].Rows[0]["ExamName"].ToString() + ", " + ds.Tables[i].Rows[0]["ExamHeldYear"].ToString();
                    PdfPTable pdfTable = new PdfPTable(5);
                    PdfPTable pdfTable1 = new PdfPTable(5);
                    decimal obtainGPA = 0;
                    decimal obtainSum = 0;
                    decimal subjectFullMarkSum = 0;
                    int subjectCount = 0;

                    if (i == 0 || i % 2 == 0)
                    {
                        
                        Header.LeftHeader(doc, fs, _writer, _contentByte, printDate, examName);
                        ct = new ColumnText(contentByte);
                        phrase = new Phrase(ds.Tables[i].Rows[0]["StudentFullName"].ToString(), rf.StudentName);
                        ct.SetSimpleColumn(phrase, 120, 481, 850, 300, 15, Element.ALIGN_LEFT);
                        ct.Go();

                        ct = new ColumnText(contentByte);
                        phrase = new Phrase(ds.Tables[i].Rows[0]["ClassName"].ToString(), rf.StudentName);
                        ct.SetSimpleColumn(phrase, 60, 456, 500, 300, 15, Element.ALIGN_LEFT);
                        ct.Go();

                        ct = new ColumnText(contentByte);
                        phrase = new Phrase(ds.Tables[i].Rows[0]["RollNumber"].ToString(), rf.StudentName);
                        ct.SetSimpleColumn(phrase, 330, 456, 500, 300, 15, Element.ALIGN_LEFT);
                        ct.Go();


                        pdfTable.TotalWidth = doc.PageSize.Width / 2 - 28;
                        pdfTable.LockedWidth = true;
                        pdfTable.SetWidths(new float[] { 20, 130, 50, 50, 100 });

                        PdfPCell cell;
                        cell = new PdfPCell(new Phrase("S.N.", rf.TableHeader));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Subject", rf.TableHeader));
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Obtained Grade", rf.TableHeader));
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Grade Point", rf.TableHeader));
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Remarks", rf.TableHeader));
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(cell);
                      
                        for (int j = 0; j < ds.Tables[i].Rows.Count; j++)
                        {
                            subjectCount++;
                            decimal obtainedTheory = Convert.ToDecimal(ds.Tables[i].Rows[j]["ObtainedTheory"]);
                            decimal obtainedPractical = Convert.ToDecimal(ds.Tables[i].Rows[j]["ObtainedPractical"]);
                            decimal Theory = Convert.ToDecimal(ds.Tables[i].Rows[j]["TheoryMarks"]);
                            decimal Practical = Convert.ToDecimal(ds.Tables[i].Rows[j]["PracticalMarks"]);

                            cell = new PdfPCell(new Phrase((j + 1).ToString(), rf.Subject));
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            pdfTable.AddCell(cell);

                            cell = new PdfPCell(new Phrase(ds.Tables[i].Rows[j]["SubjectName"].ToString(), rf.Subject));
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            pdfTable.AddCell(cell);

                            decimal totalObtain = obtainedTheory + obtainedPractical;
                            decimal subjectFullMark = Theory + Practical;
                            subjectFullMarkSum += subjectFullMark;
                            obtainSum += totalObtain;
                            cell = new PdfPCell(new Phrase(gs.ObtainGrade(totalObtain, subjectFullMark), rf.Marks));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.PaddingLeft = 5;
                            pdfTable.AddCell(cell);

                            decimal gradePont = gs.ObtainGradePoint(totalObtain, subjectFullMark);
                            obtainGPA += gradePont;
                            cell = new PdfPCell(new Phrase(gradePont.ToString(), rf.Marks));
                            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                            cell.PaddingRight = 5;
                            pdfTable.AddCell(cell);

                            cell = new PdfPCell(new Phrase(""));
                            cell.Border = 0;
                            cell.BorderWidthLeft = 0.6f;
                            cell.BorderWidthRight = 0.6f;
                            if (j == ds.Tables[i].Rows.Count - 1)
                            {
                                cell.BorderWidthBottom = 0.6f;
                            }
                            pdfTable.AddCell(cell);
                        }
                        decimal gpa = gs.GPA(obtainGPA, subjectCount);
                        string averageGrade = gs.AverageGrade(gpa);
                        int y1 = 238;
                        int y2 = 208;
                        if (classId == 2 || classId == 3 || classId == 4 || classId == 5)
                        {
                            y1 = 285;
                            y2 = 254;
                        }
                        else if (classId==6 || classId==7 || classId == 8)
                        {
                            y1 = 253;
                            y2 = 222;
                        }
                        ct = new ColumnText(contentByte);
                        phrase = new Phrase(gpa.ToString("#.##"));                       
                        ct.SetSimpleColumn(phrase, 150, y1, 450, 30, 15, Element.ALIGN_LEFT);
                        ct.Go();

                        ct = new ColumnText(contentByte);
                        phrase = new Phrase(averageGrade);
                        ct.SetSimpleColumn(phrase, 150, y2, 450, 30, 15, Element.ALIGN_LEFT);
                        ct.Go();
                        pdfTable = GradingSystemAdder.AddGradingSystem(pdfTable, classId);
                        pdfTable.WriteSelectedRows(0, -1, 15, doc.PageSize.Height - 175, contentByte);

                        PdfPTable tRe = new PdfPTable(1);
                        //tRe.DefaultCell.Border = Rectangle.NO_BORDER;
                        //tRe.DefaultCell.BorderColor = BaseColor.WHITE;                                             
                        tRe.TotalWidth = 100;
                        tRe.LockedWidth = true;
                        tRe.SetWidths(new float[] { 100 });
                        tRe = Header.WriteRemarks(gpa, tRe, classId);
                        if (classId == 2 || classId == 3 || classId == 4 || classId ==5)
                        {
                            tRe.WriteSelectedRows(0, -1, doc.PageSize.Width / 2 - 115, doc.PageSize.Height - 205, contentByte);
                        }
                        else
                        {
                            tRe.WriteSelectedRows(0, -1, doc.PageSize.Width / 2 - 100, doc.PageSize.Height - 205, contentByte);
                        }
                    }
                    else
                    {
                        Header.RightHeader(doc, fs, _writer, _contentByte, printDate, examName);
                        ct = new ColumnText(contentByte);
                        phrase = new Phrase(ds.Tables[i].Rows[0]["StudentFullName"].ToString(), rf.NameofStudent);
                        ct.SetSimpleColumn(phrase, 545, 481, 850, 300, 15, Element.ALIGN_LEFT);
                        ct.Go();

                        ct = new ColumnText(contentByte);
                        phrase = new Phrase(ds.Tables[i].Rows[0]["ClassName"].ToString(), rf.NameofStudent);
                        ct.SetSimpleColumn(phrase, 482, 456, 500, 300, 15, Element.ALIGN_LEFT);
                        ct.Go();

                        ct = new ColumnText(contentByte);
                        phrase = new Phrase(ds.Tables[i].Rows[0]["RollNumber"].ToString(), rf.NameofStudent);
                        ct.SetSimpleColumn(phrase, 1302, 456, 740, 300, 15, Element.ALIGN_LEFT);
                        ct.Go();


                        pdfTable1.TotalWidth = doc.PageSize.Width / 2 - 30;
                        pdfTable1.LockedWidth = true;
                        pdfTable1.SetWidths(new float[] { 20, 130, 50, 50, 100 });

                        PdfPCell cell;
                        cell = new PdfPCell(new Phrase("S.N.", rf.TableHeader));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable1.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Subject", rf.TableHeader));
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable1.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Obtained Grade", rf.TableHeader));
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable1.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Grade Point", rf.TableHeader));
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable1.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Remarks", rf.TableHeader));
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable1.AddCell(cell);


                        for (int j = 0; j < ds.Tables[i].Rows.Count; j++)
                        {
                            decimal obtainedTheory = Convert.ToDecimal(ds.Tables[i].Rows[j]["ObtainedTheory"]);
                            decimal obtainedPractical = Convert.ToDecimal(ds.Tables[i].Rows[j]["ObtainedPractical"]);
                            decimal Theory = Convert.ToDecimal(ds.Tables[i].Rows[j]["TheoryMarks"]);
                            decimal Practical = Convert.ToDecimal(ds.Tables[i].Rows[j]["PracticalMarks"]);
                            subjectFullMarkSum = Theory + Practical;
                            cell = new PdfPCell(new Phrase((j + 1).ToString(), rf.Subject));
                            cell.PaddingBottom = 3;
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            pdfTable1.AddCell(cell);
                            //pdfTable1.AddCell((j + 1).ToString());

                            cell = new PdfPCell(new Phrase(ds.Tables[i].Rows[j]["SubjectName"].ToString(), rf.Subject));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            pdfTable1.AddCell(cell);

                            //pdfTable1.AddCell(ds.Tables[i].Rows[j]["SubjectName"].ToString());
                            decimal totalObtain = obtainedTheory + obtainedPractical;
                            //pdfTable1.AddCell(new GradingSystem().ObtainGrade(totalObtain));
                            decimal gradePont = gs.ObtainGradePoint(totalObtain, subjectFullMarkSum);
                            obtainGPA += gradePont;

                            cell = new PdfPCell(new Phrase(gs.ObtainGrade(totalObtain, subjectFullMarkSum), rf.Marks));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.PaddingLeft = 5;
                            pdfTable1.AddCell(cell);

                            cell = new PdfPCell(new Phrase(gradePont.ToString(), rf.Marks));
                            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                            cell.PaddingRight = 5;
                            pdfTable1.AddCell(cell);

                            cell = new PdfPCell(new Phrase(""));
                            cell.Border = 0;
                            cell.BorderWidthLeft = 0.6f;
                            cell.BorderWidthRight = 0.6f;
                            if (j == ds.Tables[i].Rows.Count-1)
                            {
                                cell.BorderWidthBottom = 0.6f;
                            }
                            pdfTable1.AddCell(cell);

                            subjectCount++;
                            decimal subjectFullMark = Convert.ToDecimal(ds.Tables[i].Rows[j]["TheoryMarks"].ToString()) + Convert.ToDecimal(ds.Tables[i].Rows[j]["PracticalMarks"].ToString());
                            subjectFullMarkSum += subjectFullMark;
                            obtainSum += totalObtain;
                        }
                        decimal gpa = gs.GPA(obtainGPA, subjectCount);
                        string averageGrade = gs.AverageGrade(gpa);
                        int y1 = 230;
                        int y2 = 198;
                        if (classId == 2 || classId == 3 || classId == 4 || classId == 5)
                        {
                            y1 = 279;
                            y2 = 249;
                        }
                        else if (classId == 6 || classId == 7 || classId == 8)
                        {
                            y1 = 248;
                            y2 = 215;
                        }

                        ct = new ColumnText(contentByte);
                        phrase = new Phrase(gpa.ToString("#.##"));
                        ct.SetSimpleColumn(phrase, 562, 30, 650, y1, 15, Element.ALIGN_LEFT);
                        ct.Go();

                        ct = new ColumnText(contentByte);
                        phrase = new Phrase(averageGrade);
                        ct.SetSimpleColumn(phrase, 562, 30, 650, y2, 15, Element.ALIGN_LEFT);
                        ct.Go();
                        pdfTable1 = GradingSystemAdder.AddGradingSystem(pdfTable1, classId);
                        pdfTable1.WriteSelectedRows(0, -1, doc.PageSize.Width / 2 + 12, doc.PageSize.Height - 175, contentByte);
                        PdfPTable tRe = new PdfPTable(1);
                        tRe.DefaultCell.Border = Rectangle.NO_BORDER;
                        tRe.DefaultCell.BorderColor = BaseColor.WHITE;
                        tRe.DefaultCell.FixedHeight = 100f;
                        tRe.TotalWidth = 100;//80                       
                        tRe.SetWidths(new float[] { 100 });

                        tRe.LockedWidth = true;
                        tRe = Header.WriteRemarks(gpa, tRe, classId);
                        if (classId == 2 || classId == 3 || classId == 4 || classId == 5)
                        {
                            tRe.WriteSelectedRows(0, -1, doc.PageSize.Width - 125, doc.PageSize.Height - 205, contentByte);
                        }
                        else
                        {
                            tRe.WriteSelectedRows(0, -1, doc.PageSize.Width - 100, doc.PageSize.Height - 205, contentByte);
                        }

                        doc.NewPage();
                    }
                }
               
            //float

           

            //pdfTable = new PdfPTable(1);
            //pdfTable.TotalWidth = doc.PageSize.Width / 2 - 32;
            //pdfTable.LockedWidth = true;
            //pdfTable.AddCell("Test Table Cell Out parameter 1");
            //pdfTable.WriteSelectedRows(0, -1, doc.PageSize.Width / 2 + 16, doc.PageSize.Height - 175, contentByte);
            //doc.Open();
            //doc.Close();

        }


    }
}
