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
    public class SetColumnColorTask : ISetColumnColorTask
    {
        public ExcelWorksheet Set(ExcelWorksheet worksheet, int index, KnownColor color)
        {
            worksheet.Column(index).Style.Font.Color.SetColor(Color.FromKnownColor(color));
            return worksheet;
        }
    }
}
