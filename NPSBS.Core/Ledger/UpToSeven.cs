using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace NPSBS.Core
{
    public class UpToSeven
    {

        private DataTable _result = null;
        private FileStream _stream = null;
        private PdfContentByte contentByte = null;
        private PdfWriter writer = null;
        private Document doc = null;
        private ResultFont font = null;

        string examName = "";
        string year = "";
        string className = "";

        public UpToSeven(int ClassId, int ExaminationId, string ClassName, string ExamName, string Year )
        {
            StartupCache sc = StartupCache.Instance;
            this.examName = ExamName;
            this.year = Year;
            this.className = ClassName;
            font = StartupCache.ResultFont;
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_LedgerOne";
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@ExaminationId", ExaminationId);
            _result = DataAccess.ExecuteReaderCommand(cmd);
        }

        public void GetLeadger(string location)
        {
            try
            {
                _stream = new FileStream(location, FileMode.Create, FileAccess.Write, FileShare.None);
            }
            catch (Exception ex)
            {

                throw ex;
            }


            doc = new Document(PageSize.A4.Rotate(), 7F, 7F, 7F, 7F); ;


            writer = PdfWriter.GetInstance(doc, _stream);
            doc.Open();
            contentByte = writer.DirectContent;

            doc.AddTitle("Marks Ledger");
            doc.AddSubject("Exam Result");
            doc.AddCreator("iTextSharp");
            doc.AddAuthor("Bhuban Shrestha");
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(AppDomain.CurrentDomain.BaseDirectory + "\\logo.png");
            jpg.SetAbsolutePosition(190, 515);
            jpg.ScalePercent(32);
            doc.Add(jpg);

            WritePdf();
            doc.CloseDocument();
        }

        private void WritePdf()
        {
            font.SchoolName.Size = 18;
            PdfPTable header = new PdfPTable(1);
            header.TotalWidth = doc.PageSize.Width - 14;
            header.LockedWidth = true;
            PdfPCell cell;

            cell = new PdfPCell(new Phrase("National Peace Secondary Boarding School", font.SchoolName));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = Rectangle.NO_BORDER;
            header.AddCell(cell);

            cell = new PdfPCell(new Phrase("Gongabu, Kathmandu, Nepal", font.SchoolAddress));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = Rectangle.NO_BORDER;
            header.AddCell(cell);

            cell = new PdfPCell(new Phrase(examName + " Mark Ledger, " + year , font.ExamName));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = Rectangle.NO_BORDER;
            header.AddCell(cell);

            cell = new PdfPCell(new Phrase("Class: " + className, font.StudentClass));
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = Rectangle.NO_BORDER;
            cell.PaddingLeft = 15;
            header.AddCell(cell);
            doc.Add(header);

            float[] width = new float[_result.Columns.Count + 1];
            width[0] = 40;
            width[1] = 130;
            int c = 0;
            for (int i = 2; i < _result.Columns.Count; i++)
            {
                int len = _result.Columns[i].ColumnName.Length;
                width[i] = len>= 5? len * 5 : len * 8;
                c = i;
            }
            width[c + 1] = 50;

            PdfPTable tbl = new PdfPTable(_result.Columns.Count + 1);
            tbl.TotalWidth = doc.PageSize.Width - (doc.LeftMargin + doc.RightMargin);
            tbl.SetWidths(width);
            tbl.LockedWidth = true;
            tbl.HeaderRows = 2;

            cell = new PdfPCell(new Phrase(""));
            cell.Colspan = 2;
            tbl.AddCell(cell);

            cell = new PdfPCell(new Phrase("Subjects", font.Bold));
            cell.Colspan = _result.Columns.Count-2;
            cell.FixedHeight = 20;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            tbl.AddCell(cell);

            cell = new PdfPCell(new Phrase("Total", font.Bold));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Rowspan = 2;
            tbl.AddCell(cell);


            cell = new PdfPCell(new Phrase("Roll No."));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            tbl.AddCell(cell);

            cell = new PdfPCell(new Phrase("Name of Student"));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            tbl.AddCell(cell);

            for (int i = 2; i < _result.Columns.Count; i++)
            {
                cell = new PdfPCell(new Phrase(_result.Columns[i].ColumnName.ToString()));
                cell.FixedHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                tbl.AddCell(cell);
            }
            //cell = new PdfPCell(new Phrase(""));
            //tbl.AddCell(cell);
            
            for (int i = 0; i < _result.Rows.Count; i++)
            {
                decimal total = 0;
                for (int j = 0; j < _result.Columns.Count; j++)
                {
                    var val = _result.Rows[i][j].ToString();
                    cell = new PdfPCell(new Phrase(val));
                    if(j>=2)
                    {
                        cell = new PdfPCell(new Phrase(Convert.ToDecimal(val).ToString("N")));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        total += Convert.ToDecimal(val);
                    }
                    cell.FixedHeight = 20;
                    tbl.AddCell(cell);
                }
                cell = new PdfPCell(new Phrase(total.ToString("N")));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                tbl.AddCell(cell);
            }

            doc.Add(tbl);
            writer.PageEvent = new Footer();
        }
    }
}
