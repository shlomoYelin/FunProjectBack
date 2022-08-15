using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
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

            return worksheet;
        }
    }
}
