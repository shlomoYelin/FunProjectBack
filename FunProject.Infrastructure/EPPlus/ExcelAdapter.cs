using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using FunProject.Domain.ExcelModule;
using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using System.Linq;
using FunProject.Infrastructure.EPPlus.WorkFlows.Interfaces;
using FunProject.Domain.Attributes;

namespace FunProject.Infrastructure.EPPlus
{
    public class ExcelAdapter : IExcelAdapter
    {
        private readonly ISetColumnsNamesToSheetTask _setColumnsNamesToSheetTask1;
        private readonly IAddRowsToSheetTask _addRowsToSheetTask;
        private readonly IGetPropAndStyleAttributeDictionaryTask _getPropAndStyleAttributeDictionaryTask;
        private readonly ISetSheetStyleWorkFlow _setSheetStyleWorkFlow;

        public ExcelAdapter(ISetColumnsNamesToSheetTask setColumnsNamesToSheetTask1, IAddRowsToSheetTask addRowsToSheetTask, IGetPropAndStyleAttributeDictionaryTask getPropAndStyleAttributeDictionaryTask, ISetSheetStyleWorkFlow setSheetStyleWorkFlow)
        {
            _setColumnsNamesToSheetTask1 = setColumnsNamesToSheetTask1;
            _addRowsToSheetTask = addRowsToSheetTask;
            _getPropAndStyleAttributeDictionaryTask = getPropAndStyleAttributeDictionaryTask;
            _setSheetStyleWorkFlow = setSheetStyleWorkFlow;
        }

        public MemoryStream GenerateExcel<T>(IList<T> data, string worksheetName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var stream = new MemoryStream();

            var propsDict = _getPropAndStyleAttributeDictionaryTask.Get<T>();

            var headStyleAttributes = (ExcelHeaderStyleAttribute[])typeof(T).GetCustomAttributes(typeof(ExcelHeaderStyleAttribute), false);

            using (var xlPackage = new ExcelPackage(stream))
            {
                var worksheet = xlPackage.Workbook.Worksheets.Add(worksheetName);

                worksheet = _setColumnsNamesToSheetTask1.Set(worksheet, propsDict.Values.ToList());
                
                worksheet = _addRowsToSheetTask.Add(worksheet, data, propsDict.Keys.ToList());

                worksheet = _setSheetStyleWorkFlow.Set(worksheet, propsDict.Values.ToList(), headStyleAttributes);

                xlPackage.Save();
            }
            stream.Position = 0;

            return stream;
        }
    }
}
