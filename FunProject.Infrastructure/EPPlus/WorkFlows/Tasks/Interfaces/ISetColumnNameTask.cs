using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface ISetColumnNameTask
    {
        ExcelWorksheet Set(ExcelWorksheet worksheet, int rowIndex, int colIndex, string name);
    }
}
