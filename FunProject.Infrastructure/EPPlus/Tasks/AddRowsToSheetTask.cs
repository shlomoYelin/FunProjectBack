using FunProject.Domain.Atrributes;
using FunProject.Infrastructure.EPPlus.Tasks.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.Tasks
{
    public class AddRowsToSheetTask : IAddRowsToSheetTask
    {
        public ExcelWorksheet Add<T>(ExcelWorksheet worksheet, IList<T> data)
        {
            int colIndex = 1;
            int rowIndex = 2;

            data.ToList().ForEach(item =>
            {
                colIndex = 1;
                item.GetType().GetProperties().ToList().ForEach(prop =>
                {
                    if (prop.GetValue(item).GetType() == typeof(string))
                    {
                        worksheet.Cells[rowIndex, colIndex++].Value = (string)(prop.GetValue(item) ?? "");
                    }
                    else
                    {
                        throw new Exception("All properties must to be a string");
                    }
                });
                rowIndex++;
            });

            return worksheet;
        }
    }
}
