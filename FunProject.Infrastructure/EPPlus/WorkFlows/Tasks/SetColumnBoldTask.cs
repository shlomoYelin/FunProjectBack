using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
