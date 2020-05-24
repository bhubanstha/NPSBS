﻿using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Education.Common.FontHelper;

namespace NPSBS.Core
{
    public class ClassEight
    {
        private static FileStream fs = null;
        private static PdfContentByte contentByte = null;
        private static PdfWriter writer = null;
        private static ResultFont rf = StartupCache.ResultFont;
        private static GradingSystem gs = new GradingSystem();
        static ColumnText ct = null;
        static Phrase phrase = null;
        private static School _school;
        public static Document Publish(string location, System.Data.DataSet result, int classId, School school)
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


            Document doc = new Document(PageSize.A4.Rotate(), 7F, 7F, 7F, 7F);


            writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            contentByte = writer.DirectContent;

            doc.AddTitle("Result");
            doc.AddSubject("Exam Result");
            doc.AddCreator("iTextSharp");
            doc.AddAuthor("Bhuban Shrestha");
            //Header.WriteHeader(doc, fs, out contentByte);
            WriteResult(doc, result, writer, contentByte, classId);
            return doc;
        }

        private static void WriteResult(Document doc, System.Data.DataSet ds, PdfWriter _writer, PdfContentByte _contentByte, int classId)
        {
            int totalTable = ds.Tables.Count;
            bool isEven = totalTable % 2 == 0 ? true : false;

            for (int i = 0; i < ds.Tables.Count; i++)
            {
                string printDate = "Date: " + Convert.ToDateTime(ds.Tables[i].Rows[0]["ResultPrintDate"]).ToString("yyyy/MM/dd");
                string examName = ds.Tables[i].Rows[0]["ExamName"].ToString() + ", " + ds.Tables[i].Rows[0]["ExamHeldYear"].ToString();
                PdfPTable pdfTable = new PdfPTable(7);
                PdfPTable pdfTable1 = new PdfPTable(7);
                pdfTable.TotalWidth = doc.PageSize.Width / 2 - 28;
                pdfTable.LockedWidth = true;
                pdfTable.SetWidths(new float[] { 20, 130, 50, 50, 50, 50, 100 });

                pdfTable1.TotalWidth = doc.PageSize.Width / 2 - 30;
                pdfTable1.LockedWidth = true;
                pdfTable1.SetWidths(new float[] { 20, 130, 50, 50, 50, 50, 100 });

                decimal obtainGPA = 0;
                decimal obtainSum = 0;
                decimal subjectFullMarkSum = 0;
                int subjectCount = 0;

                if (i == 0 || i % 2 == 0)
                {

                    Header.LeftHeader(doc, fs, _writer, _contentByte, printDate, examName);
                    ct = new ColumnText(contentByte);
                    phrase = new Phrase(ds.Tables[i].Rows[0]["StudentFullName"].ToString(), rf.StudentName);
                    ct.SetSimpleColumn(phrase, 118, 481, 850, 300, 15, Element.ALIGN_LEFT);
                    ct.Go();

                    ct = new ColumnText(contentByte);
                    phrase = new Phrase(ds.Tables[i].Rows[0]["ClassName"].ToString(), rf.StudentName);
                    ct.SetSimpleColumn(phrase, 60, 456, 500, 300, 15, Element.ALIGN_LEFT);
                    ct.Go();

                    ct = new ColumnText(contentByte);
                    phrase = new Phrase(ds.Tables[i].Rows[0]["RollNumber"].ToString(), rf.StudentName);
                    ct.SetSimpleColumn(phrase, 329, 456, 500, 300, 15, Element.ALIGN_LEFT);
                    ct.Go();
                    PdfPCell cell = new PdfPCell();
                    TableHeader(pdfTable, cell);

                    for (int j = 0; j < ds.Tables[i].Rows.Count; j++)
                    {
                        subjectCount++;
                        decimal obtainedTheory = Convert.ToDecimal(ds.Tables[i].Rows[j]["ObtainedTheory"]);
                        decimal obtainedpractical = Convert.ToDecimal(ds.Tables[i].Rows[j]["ObtainedPractical"]);
                        decimal theory = Convert.ToDecimal(ds.Tables[i].Rows[j]["TheoryMarks"]);
                        decimal practical = Convert.ToDecimal(ds.Tables[i].Rows[j]["PracticalMarks"]);

                        decimal totalObtain = obtainedTheory + obtainedpractical;
                        decimal subjectFullMark = theory + practical;
                        decimal gradePont = gs.ObtainGradePoint(totalObtain, subjectFullMark);
                        obtainGPA += gradePont;
                        subjectFullMarkSum += subjectFullMark;
                        obtainSum += totalObtain;

                        pdfTable.AddCell((j + 1).ToString());
                        pdfTable.AddCell(ds.Tables[i].Rows[j]["SubjectName"].ToString());

                        cell = new PdfPCell(new Phrase(gs.ObtainGrade(obtainedTheory, theory), rf.Marks));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(cell);

                        cell = new PdfPCell(new Phrase(gs.ObtainGrade(obtainedpractical, practical), rf.Marks));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(cell);

                        cell = new PdfPCell(new Phrase(gs.ObtainGrade(totalObtain, subjectFullMark), rf.Marks));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(cell);

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

                    ct = new ColumnText(contentByte);
                    phrase = new Phrase(gpa.ToString());
                    ct.SetSimpleColumn(phrase, 150, 232, 450, 30, 15, Element.ALIGN_LEFT);
                    ct.Go();

                    ct = new ColumnText(contentByte);
                    phrase = new Phrase(averageGrade);
                    ct.SetSimpleColumn(phrase, 150, 202, 450, 30, 15, Element.ALIGN_LEFT);
                    ct.Go();
                    pdfTable = GradingSystemAdder.AddGradingSystem(pdfTable, 3, 4);
                    pdfTable.WriteSelectedRows(0, -1, 15, doc.PageSize.Height - 175, contentByte);

                    PdfPTable tRe = new PdfPTable(1);
                    tRe.DefaultCell.Border = Rectangle.NO_BORDER;
                    tRe.DefaultCell.BorderColor = BaseColor.WHITE;
                    tRe.DefaultCell.FixedHeight = 100f;
                    tRe.TotalWidth = 80;
                    tRe.LockedWidth = true;
                    tRe.SetWidths(new float[] { 80 });
                    tRe = Header.WriteRemarks(gpa, tRe, classId);
                    tRe.WriteSelectedRows(0, -1, doc.PageSize.Width - 100, doc.PageSize.Height - 205, contentByte);
                }
                else
                {
                    Header.RightHeader(doc, fs, _writer, _contentByte, printDate, examName);
                    ct = new ColumnText(contentByte);
                    phrase = new Phrase(ds.Tables[i].Rows[0]["StudentFullName"].ToString(), rf.StudentName);
                    ct.SetSimpleColumn(phrase, 543, 481, 850, 300, 15, Element.ALIGN_LEFT);
                    ct.Go();

                    ct = new ColumnText(contentByte);
                    phrase = new Phrase(ds.Tables[i].Rows[0]["ClassName"].ToString(), rf.StudentName);
                    ct.SetSimpleColumn(phrase, 483, 456, 500, 300, 15, Element.ALIGN_LEFT);
                    ct.Go();

                    ct = new ColumnText(contentByte);
                    phrase = new Phrase(ds.Tables[i].Rows[0]["RollNumber"].ToString(), rf.StudentName);
                    ct.SetSimpleColumn(phrase, 1303, 456, 740, 300, 15, Element.ALIGN_LEFT);
                    ct.Go();

                    PdfPCell cell = new PdfPCell();
                    TableHeader(pdfTable1, cell);

                    for (int j = 0; j < ds.Tables[i].Rows.Count; j++)
                    {
                        subjectCount++;
                        decimal obtainedTheory = Convert.ToDecimal(ds.Tables[i].Rows[j]["ObtainedTheory"]);
                        decimal obtainedPractical = Convert.ToDecimal(ds.Tables[i].Rows[j]["ObtainedPractical"]);
                        decimal Theory = Convert.ToDecimal(ds.Tables[i].Rows[j]["TheoryMarks"]);
                        decimal Practical = Convert.ToDecimal(ds.Tables[i].Rows[j]["PracticalMarks"]);
                        decimal subjectFullMark = Theory+  Practical;
                        decimal totalObtain = obtainedTheory + obtainedPractical;

                        subjectFullMarkSum += subjectFullMark;
                        obtainSum += totalObtain;
                        decimal gradePont = gs.ObtainGradePoint(totalObtain, subjectFullMark);
                        obtainGPA += gradePont;

                        cell = new PdfPCell(new Phrase((j + 1).ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable1.AddCell(cell);
                        pdfTable1.AddCell(ds.Tables[i].Rows[j]["SubjectName"].ToString());
                        pdfTable1.AddCell(gs.ObtainGrade(obtainedTheory, Theory));
                        pdfTable1.AddCell(gs.ObtainGrade(obtainedPractical, Practical));
                        pdfTable1.AddCell(gs.ObtainGrade(totalObtain, subjectFullMark));

                        pdfTable1.AddCell(gradePont.ToString());

                        cell = new PdfPCell(new Phrase(""));
                        cell.Border = 0;
                        cell.BorderWidthLeft = 0.6f;
                        cell.BorderWidthRight = 0.6f;
                        if (j == ds.Tables[i].Rows.Count - 1)
                        {
                            cell.BorderWidthBottom = 0.6f;
                        }
                        pdfTable1.AddCell(cell);


                    }
                    decimal gpa =gs.GPA(obtainGPA, subjectCount);
                    string averageGrade = gs.AverageGrade(gpa);

                    ct = new ColumnText(contentByte);
                    phrase = new Phrase(gpa.ToString());
                    ct.SetSimpleColumn(phrase, 568, 30, 650, 232, 15, Element.ALIGN_LEFT);
                    ct.Go();

                    ct = new ColumnText(contentByte);
                    phrase = new Phrase(averageGrade);
                    ct.SetSimpleColumn(phrase, 568, 30, 650, 202, 15, Element.ALIGN_LEFT);
                    ct.Go();
                    pdfTable1 = GradingSystemAdder.AddGradingSystem(pdfTable1, 3, 4);
                    pdfTable1.WriteSelectedRows(0, -1, doc.PageSize.Width / 2 + 16, doc.PageSize.Height - 175, contentByte);

                    PdfPTable tRe = new PdfPTable(1);
                    tRe.DefaultCell.Border = Rectangle.NO_BORDER;
                    tRe.DefaultCell.BorderColor = BaseColor.WHITE;
                    tRe.DefaultCell.FixedHeight = 100f;
                    tRe.TotalWidth = 80;
                    tRe.LockedWidth = true;
                    tRe.SetWidths(new float[] { 80 });
                    tRe = Header.WriteRemarks(gpa, tRe, classId);
                    tRe.WriteSelectedRows(0, -1, doc.PageSize.Width - 100, doc.PageSize.Height - 205, contentByte);
                    doc.NewPage();
                }
            }
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

            cell = new PdfPCell(new Phrase("Theory", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Practical", rf.TableHeader));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfTable.AddCell(cell);
        }

    }
}
