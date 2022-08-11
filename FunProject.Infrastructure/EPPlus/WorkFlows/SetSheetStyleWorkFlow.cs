using FunProject.Domain.Atrributes;
using FunProject.Infrastructure.EPPlus.WorkFlows.Interfaces;
using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.WorkFlows
{
    public class SetSheetStyleWorkFlow : ISetSheetStyleWorkFlow
    {
        private readonly ISetColumnWidthTask _setColumnWidthTask;
        private readonly ISetColumnBoldTask _setColumnBoldTask;
        private readonly ISetColumnColorTask _setColumnColorTask;
        private readonly ISetColumnNameTask _setColumnNameTask;

        public SetSheetStyleWorkFlow(ISetColumnWidthTask setColumnWidthTask, ISetColumnBoldTask setColumnBoldTask, ISetColumnColorTask setColumnColorTask, ISetColumnNameTask setColumnNameTask)
        {
            _setColumnWidthTask = setColumnWidthTask;
            _setColumnBoldTask = setColumnBoldTask;
            _setColumnColorTask = setColumnColorTask;
            _setColumnNameTask = setColumnNameTask;
        }

        public ExcelWorksheet Set<T>(ExcelWorksheet worksheet, Dictionary<PropertyInfo, ExcelColumnStyleAttribute> propsDict)
        {
            //var attributes = typeof(T).GetProperties()
            //    .Select(p => p.GetCustomAttributes(typeof(ExcelColumnStyleAttribute), false))
            //    .ToList();


            //int columnIndex = 1;
            
            foreach (var (_, atrr) in propsDict)//typeof(T).GetProperties().ToList().ForEach(prop =>
            {
                //var attributes = prop.GetCustomAttributes(typeof(ExcelColumnStyleAttribute), false);

                //todo: tasks to set head style

                //todo: split to task use agrrgate with tasksList
                //worksheet.Column(atrr.Index).Width = atrr.Width;
                worksheet = _setColumnWidthTask.Set(worksheet, atrr.Index, atrr.Width);

                //worksheet.Column(atrr.Index).Style.Font.Bold = atrr.Bold;
                worksheet = _setColumnBoldTask.Set(worksheet, atrr.Index, atrr.Bold);

                //worksheet.Column(atrr.Index).Style.Font.Color.SetColor(Color.FromKnownColor(atrr.Color));
                worksheet = _setColumnColorTask.Set(worksheet, atrr.Index, atrr.Color);

                //worksheet.Cells[1, atrr.Index].Value = atrr.Name;//todo: task already exists
                worksheet = _setColumnNameTask.Set(worksheet, 1, atrr.Index,atrr.Name);
            };
            return worksheet;
        }
        
        public ExcelWorksheet Set(ExcelWorksheet worksheet, IList<ExcelColumnStyleAttribute> attributes)
        {
            //var attributes = typeof(T).GetProperties()
            //    .Select(p => p.GetCustomAttributes(typeof(ExcelColumnStyleAttribute), false))
            //    .ToList();

            //todo: chang all attr to atrr
            //int columnIndex = 1;
            attributes.ToList().ForEach(attr =>
            {
                worksheet = _setColumnWidthTask.Set(worksheet, attr.Index, attr.Width);

                //worksheet.Column(atrr.Index).Style.Font.Bold = atrr.Bold;
                worksheet = _setColumnBoldTask.Set(worksheet, attr.Index, attr.Bold);

                //worksheet.Column(attr.Index).Style.Font.Color.SetColor(Color.FromKnownColor(attr.Color));
                worksheet = _setColumnColorTask.Set(worksheet, attr.Index, attr.Color);

                //worksheet.Cells[1, attr.Index].Value = attr.Name;//todo: task already exists
                worksheet = _setColumnNameTask.Set(worksheet, 1, attr.Index,attr.Name);
            });
            return worksheet;
        }
    }
}
