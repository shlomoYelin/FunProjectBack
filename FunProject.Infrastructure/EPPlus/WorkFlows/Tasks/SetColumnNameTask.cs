using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class SetColumnNameTask : ISetColumnNameTask
    {
        public ExcelWorksheet Set(ExcelWorksheet worksheet, int rowIndex, int colIndex, string name)
        {
            worksheet.Cells[rowIndex, colIndex].Value = name;
            return worksheet;
        }
    }
}
