using FunProject.Application.ExcelModule;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml.Style;
using FunProject.Infrastructure.EPPlus.Tasks.Interfaces;

namespace FunProject.Infrastructure.EPPlus
{
    public class ExcelAdapter : IExcelAdapter
    {
        private readonly IAddColumnsToSheetTask _addColumnsToSheetTask;
        private readonly IAddRowsToSheetTask _addRowsToSheetTask;
        private readonly ISetAsBlodTask _setAsBlodTask;

        public ExcelAdapter(
            IAddColumnsToSheetTask addColumnsToSheetTask, 
            IAddRowsToSheetTask addRowsToSheetTask, 
            ISetAsBlodTask setAsBlodTask)
        {
            _addColumnsToSheetTask = addColumnsToSheetTask;
            _addRowsToSheetTask = addRowsToSheetTask;
            _setAsBlodTask = setAsBlodTask;
        }

        public MemoryStream GenerateExcel<T>(IList<T> data, string worksheetName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var stream = new MemoryStream();

            using (var xlPackage = new ExcelPackage(stream))
            {
                var worksheet = xlPackage.Workbook.Worksheets.Add(worksheetName);

                worksheet = _addColumnsToSheetTask.Add<T>(worksheet);

                worksheet = _setAsBlodTask.Set(worksheet, (1, 1), (typeof(T).GetProperties().Length, 1));
                
                worksheet = _addRowsToSheetTask.Add(worksheet, data);

                xlPackage.Save();
            }
            stream.Position = 0;

            return stream;
        }
    }
}
