using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class SetColumnWidthTask : ISetColumnWidthTask
    {
        public ExcelWorksheet Set(ExcelWorksheet worksheet, int index, double width)
        {
            worksheet.Column(index).Width = width;
            return worksheet;
        }
    }
}
