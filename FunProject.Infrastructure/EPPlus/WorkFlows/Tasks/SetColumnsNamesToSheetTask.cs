using FunProject.Domain.Attributes;
using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class SetColumnsNamesToSheetTask : ISetColumnsNamesToSheetTask
    {
        public ExcelWorksheet Set(ExcelWorksheet worksheet, IList<ExcelColumnStyleAttribute> attributes)
        {
            attributes.ToList().ForEach(attr =>
            {
                worksheet.Cells[1, attr.Index].Value = attr.Name;
            });

            return worksheet;
        }
    }
}
