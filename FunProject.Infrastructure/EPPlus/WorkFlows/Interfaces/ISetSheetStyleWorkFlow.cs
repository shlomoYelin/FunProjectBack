using FunProject.Domain.Attributes;
using OfficeOpenXml;
using System.Collections.Generic;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Interfaces
{
    public interface ISetSheetStyleWorkFlow
    {
        public ExcelWorksheet Set(ExcelWorksheet worksheet, IList<ExcelColumnStyleAttribute> attributes, ExcelHeaderStyleAttribute[] headStyleAttributes);

    }
}
