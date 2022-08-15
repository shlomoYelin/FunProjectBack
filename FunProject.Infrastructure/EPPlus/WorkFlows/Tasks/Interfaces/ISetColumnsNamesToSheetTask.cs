using FunProject.Domain.Attributes;
using OfficeOpenXml;
using System.Collections.Generic;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface ISetColumnsNamesToSheetTask
    {
        ExcelWorksheet Set(ExcelWorksheet worksheet, IList<ExcelColumnStyleAttribute> attributes);
    }
}
