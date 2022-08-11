using FunProject.Domain.Atrributes;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Reflection;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface ISetColumnsNamesToSheetTask
    {
        //ExcelWorksheet Add<T>(ExcelWorksheet worksheet);
        //ExcelWorksheet Set(ExcelWorksheet worksheet, Dictionary<PropertyInfo, ExcelColumnStyleAttribute> propsDict);
        ExcelWorksheet Set(ExcelWorksheet worksheet, IList<ExcelColumnStyleAttribute> attributes);
    }
}
