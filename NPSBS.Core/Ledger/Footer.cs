using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace NPSBS.Core
{
    internal class Footer : PdfPageEventHelper
    {

        //Header
        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            base.OnOpenDocument(writer, document);

        }

        public override void OnStartPage(PdfWriter writer, Document document)
        {
                base.OnStartPage(writer, document);
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
            PdfPTable tabFot = new PdfPTable(2);
            PdfPCell cel;
            tabFot.TotalWidth = document.PageSize.Width - (document.LeftMargin + document.RightMargin);
            tabFot.LockedWidth = true;
            cel = new PdfPCell(new Phrase("        _________________________\n                Principal Signature"));
            cel.Border = Rectangle.NO_BORDER;
            tabFot.AddCell(cel);

            cel = new PdfPCell(new Phrase("                                              _________________________\n                                                     Class Teacher Signature "));
            cel.Border = Rectangle.NO_BORDER;
            tabFot.AddCell(cel);

            tabFot.WriteSelectedRows(0, -1, 8, document.Bottom+30, writer.DirectContent);

        }
    }
}
