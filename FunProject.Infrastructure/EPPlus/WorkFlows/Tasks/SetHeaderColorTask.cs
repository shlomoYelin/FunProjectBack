using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class SetHeaderColorTask : ISetHeaderColorTask
    {
        public ExcelWorksheet Set(ExcelWorksheet worksheet, KnownColor color)
        {
            worksheet.Row(1).Style.Fill.SetBackground(Color.FromKnownColor(color));
            return worksheet;
        }
    }
}
