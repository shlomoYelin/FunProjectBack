using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
