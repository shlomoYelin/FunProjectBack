using FunProject.Domain.Atrributes;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Interfaces
{
    public interface ISetSheetStyleWorkFlow
    {
        public ExcelWorksheet Set<T>(ExcelWorksheet worksheet, Dictionary<PropertyInfo, ExcelColumnStyleAttribute> propsDict);
        public ExcelWorksheet Set(ExcelWorksheet worksheet, IList<ExcelColumnStyleAttribute> attributes);

    }
}
