using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class SetHeaderBlodTask : ISetHeaderBlodTask
    {
        public ExcelWorksheet Set(ExcelWorksheet worksheet, bool blod)
        {
            worksheet.Row(1).Style.Font.Bold = blod;    
            return worksheet;
        }
    }
}
