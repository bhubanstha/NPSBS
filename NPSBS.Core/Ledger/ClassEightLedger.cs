using System;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Utility;

namespace NPSBS.Core
{
	public class ClassEightLedger
	{
		private DataSet _result = null;
		private DataTable _subject = null;
		private FileStream _stream = null;
		private PdfContentByte contentByte = null;
		private PdfWriter writer = null;
		private Document doc = null;
		private ResultFont font = null;
		private School _school;
		string examName = "";
		string year = "";
		string className = "";

		public ClassEightLedger(int ClassId, int ExaminationId, string ClassName, string ExamName, string Year)
		{
			StartupCache sc = StartupCache.Instance;
			this.examName = ExamName;
			this.year = Year;
			this.className = ClassName;
			font = StartupCache.ResultFont;
			var cmd = DataAccess.CreateCommand();
			cmd.CommandText = "usp_LedgerEight";
			cmd.Parameters.AddWithValue("@ClassId", ClassId);
			cmd.Parameters.AddWithValue("@ExaminationId", ExaminationId);
			_result = DataAccess.ExecuteDataSet(cmd);

			cmd.Parameters.Clear();
			cmd.CommandText = "usp_Subject_ByClass";
			cmd.Parameters.AddWithValue("@ClassId", ClassId);
			_subject = DataAccess.ExecuteReaderCommand(cmd);
		}

		public void GetLeadger(string location, School school)
		{
			try
			{
				_school = school;
				_stream = new FileStream(location, FileMode.Create, FileAccess.Write, FileShare.None);
			}
			catch (Exception ex)
			{

				throw ex;
			}


			doc = new Document(PageSize.A4.Rotate(), 7F, 7F, 7F, 7F);


			writer = PdfWriter.GetInstance(doc, _stream);
			doc.Open();
			contentByte = writer.DirectContent;

			doc.AddTitle("Marks Ledger");
			doc.AddSubject("Exam Result");
			doc.AddCreator("iTextSharp");
			doc.AddAuthor("Bhuban Shrestha");
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(Constant.SchoolLogo);
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

			cell = new PdfPCell(new Phrase(_school.SchoolName, font.SchoolName));
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			cell.Border = Rectangle.NO_BORDER;
			header.AddCell(cell);

			cell = new PdfPCell(new Phrase(_school.Address, font.SchoolAddress));
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			cell.Border = Rectangle.NO_BORDER;
			header.AddCell(cell);

			cell = new PdfPCell(new Phrase(examName + " Mark Ledger, " + year, font.ExamName));
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			cell.Border = Rectangle.NO_BORDER;
			header.AddCell(cell);

			cell = new PdfPCell(new Phrase("Class: " + className, font.StudentClass));
			cell.HorizontalAlignment = Element.ALIGN_LEFT;
			cell.Border = Rectangle.NO_BORDER;
			cell.PaddingLeft = 15;
			header.AddCell(cell);
			doc.Add(header);

			int cols = (_subject.Rows.Count * 2) + 3;

			float[] width = new float[cols];
			width[0] = 40;
			width[1] = 120;
			int c = 0;
			for (int i = 2; i < (_subject.Rows.Count * 2) + 2; i++)
			{
				width[i] = 50;
				c = i;
			}
			width[c + 1] = 50;

			PdfPTable tbl = new PdfPTable(cols);
			tbl.TotalWidth = doc.PageSize.Width - (doc.LeftMargin + doc.RightMargin);
			tbl.SetWidths(width);
			tbl.LockedWidth = true;
			tbl.HeaderRows = 3;

			cell = new PdfPCell(new Phrase(""));
			cell.Colspan = 2;
			tbl.AddCell(cell);

			cell = new PdfPCell(new Phrase("Subjects", font.Bold));
			cell.Colspan = (_subject.Rows.Count * 2);
			cell.FixedHeight = 20;
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			tbl.AddCell(cell);

			cell = new PdfPCell(new Phrase("Total", font.Bold));
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			cell.Rowspan = 3;
			tbl.AddCell(cell);


			cell = new PdfPCell(new Phrase("Roll No.", font.LedgerSubject));
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			cell.Rowspan = 2;
			tbl.AddCell(cell);

			cell = new PdfPCell(new Phrase("Name of Student", font.LedgerSubject));
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			cell.Rowspan = 2;
			tbl.AddCell(cell);

			for (int i = 0; i < _subject.Rows.Count; i++)
			{
				cell = new PdfPCell(new Phrase(_subject.Rows[i][3].ToString(), font.LedgerSubject));
				cell.FixedHeight = 20;
				cell.Colspan = 2;
				cell.HorizontalAlignment = Element.ALIGN_CENTER;
				tbl.AddCell(cell);
			}


			for (int i = 0; i < _subject.Rows.Count; i++)
			{
				cell = new PdfPCell(new Phrase("Th.", font.LedgerSubject));
				cell.FixedHeight = 20;
				cell.HorizontalAlignment = Element.ALIGN_CENTER;
				tbl.AddCell(cell);
				cell = new PdfPCell(new Phrase("Pr.", font.LedgerSubject));
				cell.FixedHeight = 20;
				cell.HorizontalAlignment = Element.ALIGN_CENTER;
				tbl.AddCell(cell);
			}


			for (int i = 0; i < _result.Tables.Count; i++)
			{
				if (_result.Tables[i].Rows.Count == _subject.Rows.Count) //check if result has got all subject marks
				{
					decimal total = 0;
					string rollNo = _result.Tables[i].Rows[0][0].ToString();
					string name = _result.Tables[i].Rows[0][1].ToString();
					cell = new PdfPCell(new Phrase(rollNo, font.LedgerSubject));
					cell.FixedHeight = 20;
					tbl.AddCell(cell);

					cell = new PdfPCell(new Phrase(name, font.LedgerSubject));
					cell.FixedHeight = 20;
					tbl.AddCell(cell);

					for (int j = 0; j < _result.Tables[i].Rows.Count; j++)
					{
						decimal th = _result.Tables[i].Rows[j][3].ToString() == "" ? 0 : Convert.ToDecimal(_result.Tables[i].Rows[j][3].ToString());
						decimal pr = _result.Tables[i].Rows[j][4].ToString() == "" ? 0 : Convert.ToDecimal(_result.Tables[i].Rows[j][4].ToString());
						total += (th + pr);
						cell = new PdfPCell(new Phrase(th == 0 ? "-" : th.ToString("N"), font.LedgerSubject));
						cell.FixedHeight = 20;
						cell.HorizontalAlignment = Element.ALIGN_CENTER;
						tbl.AddCell(cell);

						cell = new PdfPCell(new Phrase(pr == 0 ? "-" : pr.ToString("N"), font.LedgerSubject));
						cell.FixedHeight = 20;
						cell.HorizontalAlignment = Element.ALIGN_CENTER;
						tbl.AddCell(cell);
					}
					cell = new PdfPCell(new Phrase(total.ToString("N"), font.LedgerSubject));
					cell.FixedHeight = 20;
					cell.HorizontalAlignment = Element.ALIGN_CENTER;
					tbl.AddCell(cell);
				}
			}

			doc.Add(tbl);
			writer.PageEvent = new Footer();
		}
	}
}
