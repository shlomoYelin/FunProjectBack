using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using FunProject.Domain.ExcelModule;
using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using System.Linq;
using FunProject.Domain.Atrributes;
using FunProject.Infrastructure.EPPlus.WorkFlows.Interfaces;

namespace FunProject.Infrastructure.EPPlus
{
    public class ExcelAdapter : IExcelAdapter
    {
        private readonly ISetColumnsNamesToSheetTask _setColumnsNamesToSheetTask1;
        private readonly IAddRowsToSheetTask _addRowsToSheetTask;
        private readonly ISetAsBlodTask _setAsBlodTask;
        private readonly IGetPropAndStyleAtrributeDictionaryTask _getPropAndStyleAtrributeDictionaryTask;
        private readonly ISetSheetStyleWorkFlow _setSheetStyleWorkFlow;

        public ExcelAdapter(ISetColumnsNamesToSheetTask setColumnsNamesToSheetTask1, IAddRowsToSheetTask addRowsToSheetTask, ISetAsBlodTask setAsBlodTask, IGetPropAndStyleAtrributeDictionaryTask getPropAndStyleAtrributeDictionaryTask, ISetSheetStyleWorkFlow setSheetStyleWorkFlow)
        {
            _setColumnsNamesToSheetTask1 = setColumnsNamesToSheetTask1;
            _addRowsToSheetTask = addRowsToSheetTask;
            _setAsBlodTask = setAsBlodTask;
            _getPropAndStyleAtrributeDictionaryTask = getPropAndStyleAtrributeDictionaryTask;
            _setSheetStyleWorkFlow = setSheetStyleWorkFlow;
        }

        public MemoryStream GenerateExcel<T>(IList<T> data, string worksheetName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var stream = new MemoryStream();

            //var propsDict = typeof(T).GetProperties()
            //    .Where(prop => prop
            //        .GetCustomAttributes(typeof(ExcelColumnStyleAttribute), false).Length > 0)

            //    .ToDictionary(prop => prop,
            //    prop => (ExcelColumnStyleAttribute)prop
            //    .GetCustomAttributes(typeof(ExcelColumnStyleAttribute), false)
            //    .First())

            //    .OrderBy(prop => prop.Value.Index);

            var propsDict = _getPropAndStyleAtrributeDictionaryTask.Get<T>();

            using (var xlPackage = new ExcelPackage(stream))
            {
                var worksheet = xlPackage.Workbook.Worksheets.Add(worksheetName);

                //worksheet = _addColumnsToSheetTask.Add<T>(worksheet);
                worksheet = _setColumnsNamesToSheetTask1.Set(worksheet, propsDict.Values.ToList());
                //todo: workFlow - set head style
                worksheet = _setAsBlodTask.Set(worksheet, (1, 1), (propsDict.Count, 1));

                //worksheet = _addRowsToSheetTask.Add(worksheet, data);
                worksheet = _addRowsToSheetTask.Add(worksheet, data, propsDict.Keys.ToList());

                worksheet = _setSheetStyleWorkFlow.Set(worksheet, propsDict.Values.ToList());

                xlPackage.Save();
            }
            stream.Position = 0;

            return stream;
        }
    }
}
