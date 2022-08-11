using FunProject.Domain.Atrributes;
using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class SetColumnsStyleTask : ISetColumnsStyleTask
    {
        public ExcelWorksheet Set<T>(ExcelWorksheet worksheet)
        {
            int columnIndex = 1;
            typeof(T).GetProperties().ToList().ForEach(prop =>
            {
                var attributes = prop.GetCustomAttributes(typeof(ExcelColumnStyleAttribute), false);

                if (attributes.Length > 0)
                {
                    var columnStyle = (ExcelColumnStyleAttribute)attributes[0];

                    worksheet.Column(columnIndex++).Width = columnStyle.Width;
                    worksheet.Column(columnIndex++).Style.Font.Bold = columnStyle.Bold;
                    worksheet.Column(columnIndex++).Style.Font.Color.SetColor(Color.FromKnownColor(columnStyle.Color));
                    worksheet.Cells[1, columnIndex].Value = columnStyle.Name;

                }
            });
        }
    }
}
