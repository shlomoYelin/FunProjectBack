using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System.Drawing;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class SetColumnColorTask : ISetColumnColorTask
    {
        public ExcelWorksheet Set(ExcelWorksheet worksheet, int index, KnownColor color)
        {
            worksheet.Column(index).Style.Fill.SetBackground(Color.FromKnownColor(color));
            return worksheet;
        }
    }
}
