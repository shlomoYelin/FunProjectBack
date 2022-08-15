using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class SetColumnBoldTask : ISetColumnBoldTask
    {
        public ExcelWorksheet Set(ExcelWorksheet worksheet, int index, bool bold)
        {
            worksheet.Column(index).Style.Font.Bold = bold;
            return worksheet;
        }
    }
}
