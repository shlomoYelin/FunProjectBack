using FunProject.Infrastructure.EPPlus.Tasks.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.Tasks
{
    public class SetAsBlodTask : ISetAsBlodTask
    {
        public ExcelWorksheet Set(ExcelWorksheet worksheet, (int column, int row) startIndex, (int column, int row) endIndex)
        {
            worksheet.Cells[
                startIndex.row,
                startIndex.column, 
                endIndex.row, 
                endIndex.column
                ]
                .Style.Font.Bold = true;

            return worksheet;
        }
    }
}
