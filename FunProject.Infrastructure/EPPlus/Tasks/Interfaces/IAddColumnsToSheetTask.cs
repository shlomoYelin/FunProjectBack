using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.Tasks.Interfaces
{
    public interface IAddColumnsToSheetTask
    {
        ExcelWorksheet Add<T>(ExcelWorksheet worksheet);
    }
}
