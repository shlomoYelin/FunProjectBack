using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class AddRowsToSheetTask : IAddRowsToSheetTask
    {
        public ExcelWorksheet Add<T>(ExcelWorksheet worksheet, IList<T> data, IList<PropertyInfo> properties)
        {
            int colIndex = 1;
            int rowIndex = 2;

            data.ToList().ForEach(item =>
            {
                colIndex = 1;
                properties.ToList().ForEach(prop =>
                {
                    worksheet.Cells[rowIndex, colIndex++].Value = prop.GetValue(item);//.ToString();
                });
                rowIndex++;
            });

            return worksheet;
        }
    }
}
