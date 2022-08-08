using FunProject.Domain.Atrributes;
using FunProject.Infrastructure.EPPlus.Tasks.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.Tasks
{
    public class AddColumnsToSheetTask : IAddColumnsToSheetTask
    {
        public ExcelWorksheet Add<T>(ExcelWorksheet worksheet)
        {
            int colIndex = 1;
            typeof(T).GetProperties().ToList().ForEach(prop =>
            {
                var attributes = prop.GetCustomAttributes(typeof(DisplaydNameAttribute), false);

                worksheet.Cells[1, colIndex++].Value =
                attributes.Length > 0
                ? ((DisplaydNameAttribute)attributes.First()).Name
                : prop.Name;
            });

            return worksheet;
        }
    }
}
