using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Montessori.Core
{
    public class ResultFont
    {

        public Font SchoolName { get; private set; }
        public Font SchoolAddress { get; private set; }
        public Font SchoolPhone { get; private set; }
        public Font ExamName { get; private set; }
        public Font GradeSheet { get; private set; }
        public Font ResultDate { get; private set; }
        public Font NameofStudent { get; private set; }
        public Font StudentName { get; private set; }
        public Font Class { get; private set; }
        public Font StudentClass { get; private set; }
        public Font RollNumber { get; private set; }
        public Font StudentRollNumber { get; private set; }
        public Font TableHeader { get; private set; }
        public Font Subject { get; private set; }
        public Font Marks { get; private set; }
        public Font Remarks { get; private set; }
        public Font GPAFont { get; private set; }
        public Font GradingSystem { get; private set; }
        public Font Footer { get; private set; }

        public Font Arial { get; private set; }

        public Font Small { get; set; }
        public Font NurserySchool { get; private set; }
        public Font NurseryResultDate { get; private set; }
        public Font StatementOfMark { get; private set; }
        // DirectoryInfo dirWindowsFolder = Directory.GetParent(Environment.GetFolderPath(System.Environment.SpecialFolder.System));




        public ResultFont()
        {
            string fontLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fonts");
            BaseFont Bernard = BaseFont.CreateFont(fontLocation + "\\BERNHC.ttf", BaseFont.CP1252, BaseFont.EMBEDDED);
            BaseFont TimesBold = BaseFont.CreateFont(fontLocation + "\\timesbd.ttf", BaseFont.CP1252, BaseFont.EMBEDDED);
            BaseFont TimesBoldItalic = BaseFont.CreateFont(fontLocation + "\\timesbi.ttf", BaseFont.CP1252, BaseFont.EMBEDDED);
            BaseFont TimesNormal = BaseFont.CreateFont(fontLocation + "\\times.ttf", BaseFont.CP1252, BaseFont.EMBEDDED);
            BaseFont Bodoni = BaseFont.CreateFont(fontLocation + "\\BOD_PSTC.ttf", BaseFont.CP1252, BaseFont.EMBEDDED);
            BaseFont Impact = BaseFont.CreateFont(fontLocation + "\\impact.ttf", BaseFont.CP1252, BaseFont.EMBEDDED);
            BaseFont ArialBold = BaseFont.CreateFont(fontLocation + "\\arialbd.ttf", BaseFont.CP1252, BaseFont.EMBEDDED);
            BaseFont ArialNormal = BaseFont.CreateFont(fontLocation + "\\arial.ttf", BaseFont.CP1252, BaseFont.EMBEDDED);
            BaseFont Comic = BaseFont.CreateFont(fontLocation + "\\comic.ttf", BaseFont.CP1252, BaseFont.EMBEDDED);
            BaseFont Baskerville = BaseFont.CreateFont(fontLocation + "\\BASKVILL.ttf", BaseFont.CP1252, BaseFont.EMBEDDED);
            BaseFont Serifa = BaseFont.CreateFont(fontLocation + "\\SERIFAI.ttf", BaseFont.CP1252, BaseFont.EMBEDDED);

            SchoolName = new Font(Bernard, 18, Font.NORMAL, BaseColor.BLACK);
            SchoolAddress = new Font(TimesBold, 14, Font.NORMAL, BaseColor.BLACK);
            SchoolPhone = new Font(TimesBold, 11, Font.NORMAL, BaseColor.BLACK);
            ExamName = new Font(Bodoni, 18, Font.NORMAL, BaseColor.BLACK);
            GradeSheet = new Font(Impact, 16, Font.UNDERLINE, BaseColor.BLACK);
            NameofStudent = new Font(ArialBold, 12, Font.NORMAL, BaseColor.BLACK);
            ResultDate = new Font(Baskerville, 12, Font.NORMAL, BaseColor.BLACK);
            NurserySchool = new Font(Baskerville, 12, Font.NORMAL, BaseColor.BLACK);
            StudentClass = NameofStudent;
            StudentRollNumber = NameofStudent;
            TableHeader = new Font(TimesBoldItalic, 10, Font.NORMAL, BaseColor.BLACK);
            Subject = new Font(TimesBoldItalic, 12, Font.NORMAL, BaseColor.BLACK);
            Marks = new Font(TimesNormal, 12, Font.NORMAL, BaseColor.BLACK);
            Remarks = new Font(ArialBold, 12, Font.BOLDITALIC, BaseColor.BLACK);
            GPAFont = new Font(TimesBoldItalic, 10, Font.NORMAL, BaseColor.BLACK);
            GradingSystem = new Font(Comic, 6, Font.NORMAL, BaseColor.BLACK);
            Arial = new Font(ArialBold, 12, Font.NORMAL, BaseColor.BLACK);
            StudentName = NameofStudent;
            NurserySchool = new Font(Serifa, 25, Font.BOLD, BaseColor.BLACK);
            StatementOfMark = new Font(ArialBold, 20, Font.NORMAL, BaseColor.BLACK);
            Small = new Font(TimesNormal, 9, Font.ITALIC, BaseColor.BLACK);
        }


    }
}
