using OfficeOpenXml;
using System.Collections.Generic;
using System.Reflection;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface IAddRowsToSheetTask
    {
        //ExcelWorksheet Add<T>(ExcelWorksheet worksheet, IList<T> data);
        ExcelWorksheet Add<T>(ExcelWorksheet worksheet, IList<T> data, IList<PropertyInfo> properties);
    }
}
