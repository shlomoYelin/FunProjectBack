using FunProject.Domain.Atrributes;
using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class SetColumnsNamesToSheetTask : ISetColumnsNamesToSheetTask
    {
        //public ExcelWorksheet Add<T>(ExcelWorksheet worksheet)
        //{
        //    int colIndex = 1;
        //    typeof(T).GetProperties().ToList().ForEach(prop =>
        //    {
        //        var attributes = prop.GetCustomAttributes(typeof(DisplaydNameAttribute), false);

        //        worksheet.Cells[1, colIndex++].Value =
        //          attributes.Length > 0
        //          ? ((DisplaydNameAttribute)attributes.First()).Name
        //          : prop.Name;
        //    });

        //    return worksheet;
        //}

        //public ExcelWorksheet Set(ExcelWorksheet worksheet, Dictionary<PropertyInfo, ExcelColumnStyleAttribute> propsDict)
        //{
        //    //int colIndex = 1;
        //    //propsDict.AsParallel().ForAll(prop =>
        //    foreach (var (_, atrr) in propsDict)//propsDict.ForEach(prop =>
        //    {
        //        //var attributes = prop.GetCustomAttributes(typeof(DisplaydNameAttribute), false);

        //        worksheet.Cells[1, atrr.Index].Value = atrr.Name;
        //        //attributes.Length > 0
        //        //? ((DisplaydNameAttribute)attributes.First()).Name
        //        //: prop.Name;
        //    }

        //    return worksheet;
        //}

        public ExcelWorksheet Set(ExcelWorksheet worksheet, IList<ExcelColumnStyleAttribute> attributes)
        {
            attributes.ToList().ForEach(atrr =>
            {
                worksheet.Cells[1, atrr.Index].Value = atrr.Name;
            });

            return worksheet;
        }
    }
}
