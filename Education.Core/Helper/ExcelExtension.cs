using System.Linq;
using OfficeOpenXml;
using System.Data;

namespace Education.Common
{
    public static class ExcelExtension
    {
        public static DataTable ToDataTable(this ExcelPackage package)
        {
            ExcelWorksheet workSheet = package.Workbook.Worksheets.First();
            DataTable tbl = new DataTable();
            foreach (var firstRowCell in workSheet.Cells[1,1,1, workSheet.Dimension.End.Column])
            {
                tbl.Columns.Add(firstRowCell.Text);
            }
            for (int rowNumber = 2; rowNumber <= workSheet.Dimension.End.Row; rowNumber++)
            {
            	var row = workSheet.Cells[rowNumber,1,rowNumber,workSheet.Dimension.End.Column];
                var newRow = tbl.NewRow();
                foreach (var cell in row)
                {
                    newRow[cell.Start.Column-1] = cell.Text;
                }
                tbl.Rows.Add(newRow);
            }
            return tbl;
        }

    }
}
