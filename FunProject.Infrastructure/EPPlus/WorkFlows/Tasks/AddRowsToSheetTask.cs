using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class AddRowsToSheetTask : IAddRowsToSheetTask
    {
        //public ExcelWorksheet Add<T>(ExcelWorksheet worksheet, IList<T> data)
        //{
        //    int colIndex = 1;
        //    int rowIndex = 2;

        //    data.ToList().ForEach(item =>
        //    {
        //        colIndex = 1;
        //        item.GetType().GetProperties().ToList().ForEach(prop =>
        //        {
        //            if (prop.GetValue(item).GetType() == typeof(string))
        //            {
        //                worksheet.Cells[rowIndex, colIndex++].Value = (string)(prop.GetValue(item) ?? "");
        //            }
        //            else
        //            {
        //                throw new Exception("All properties must to be a string");
        //            }
        //        });
        //        rowIndex++;
        //    });

        //    return worksheet;
        //}

        public ExcelWorksheet Add<T>(ExcelWorksheet worksheet, IList<T> data, IList<PropertyInfo> properties)
        {
            int colIndex = 1;
            int rowIndex = 2;

            data.ToList().ForEach(item =>
            {
                colIndex = 1;
                properties.ToList().ForEach(prop =>
                {
                    //if (prop.GetValue(item).GetType() == typeof(string))
                    //{
                    worksheet.Cells[rowIndex, colIndex++].Value = prop.GetValue(item).ToString();
                    //}
                    //else
                    //{
                    //    throw new Exception("All properties must to be a string");
                    //}
                });
                rowIndex++;
            });

            return worksheet;
        }
    }
}
