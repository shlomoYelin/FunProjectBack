using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class SetAsBlodTask : ISetAsBlodTask
    {
        public ExcelWorksheet Set(ExcelWorksheet worksheet, (int column, int row) startIndex, (int column, int row) endIndex)
        {
            worksheet.Cells[
                startIndex.row,
                startIndex.column,
                endIndex.row,
                endIndex.column
                ]
                .Style.Font.Bold = true;

            worksheet.Cells[
                startIndex.row,
                startIndex.column,
                endIndex.row,
                endIndex.column
                ]
                .Style.Fill.SetBackground(Color.FromKnownColor(KnownColor.White));

            worksheet.Cells[5, 5]

            worksheet.Column(1).Style.Font.Color.SetColor(KnownColor.Blue);
            worksheet.Column(1).Style.Font.Color.SetColor(Color.FromKnownColor(KnownColor.Red));

            worksheet.Column(1).Width = 20.5;
            worksheet.Row(1).Style.Font.Bold = true;

            var c = Color.White;


            worksheet.Column(1).Style.Fill.BackgroundColor.SetColor(c);
            //.SetColor(0xFF, 0x00, 0x61, 0x00);

            return worksheet;
        }
    }
}
