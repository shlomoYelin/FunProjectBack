using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class SetHeaderHeightTask : ISetHeaderHeightTask
    {
        public ExcelWorksheet Set(ExcelWorksheet worksheet, double height)
        {
            worksheet.Row(1).Height = height;
            return worksheet;
        }
    }
}
