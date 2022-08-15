using FunProject.Domain.Attributes;
using FunProject.Infrastructure.EPPlus.WorkFlows.Interfaces;
using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Infrastructure.EPPlus.WorkFlows
{
    public class SetSheetStyleWorkFlow : ISetSheetStyleWorkFlow
    {
        private readonly ISetColumnWidthTask _setColumnWidthTask;
        private readonly ISetColumnBoldTask _setColumnBoldTask;
        private readonly ISetColumnColorTask _setColumnColorTask;
        private readonly ISetColumnNameTask _setColumnNameTask;
        private readonly ISetHeaderColorTask _setHeaderColorTask;
        private readonly ISetHeaderBlodTask _setHeaderBlodTask;
        private readonly ISetHeaderHeightTask _setHeaderHeightTask;

        public SetSheetStyleWorkFlow(ISetColumnWidthTask setColumnWidthTask, ISetColumnBoldTask setColumnBoldTask, ISetColumnColorTask setColumnColorTask, ISetColumnNameTask setColumnNameTask, ISetHeaderColorTask setHeaderColorTask, ISetHeaderBlodTask setHeaderBlodTask, ISetHeaderHeightTask setHeaderHeightTask)
        {
            _setColumnWidthTask = setColumnWidthTask;
            _setColumnBoldTask = setColumnBoldTask;
            _setColumnColorTask = setColumnColorTask;
            _setColumnNameTask = setColumnNameTask;
            _setHeaderColorTask = setHeaderColorTask;
            _setHeaderBlodTask = setHeaderBlodTask;
            _setHeaderHeightTask = setHeaderHeightTask;
        }

        public ExcelWorksheet Set(ExcelWorksheet worksheet, IList<ExcelColumnStyleAttribute> attributes, ExcelHeaderStyleAttribute[] headStyleAttributes)
        {
            attributes.ToList().ForEach(attr =>
            {
                worksheet = _setColumnWidthTask.Set(worksheet, attr.Index, attr.Width);

                worksheet = _setColumnBoldTask.Set(worksheet, attr.Index, attr.Bold);

                worksheet = _setColumnColorTask.Set(worksheet, attr.Index, attr.Color);

                worksheet = _setColumnNameTask.Set(worksheet, 1, attr.Index, attr.Name);

                if (headStyleAttributes.Length > 0)
                {
                    worksheet = _setHeaderColorTask.Set(worksheet, headStyleAttributes[0].Color);

                    worksheet = _setHeaderBlodTask.Set(worksheet, headStyleAttributes[0].Bold);

                    worksheet = _setHeaderHeightTask.Set(worksheet, headStyleAttributes[0].Height);
                }
            });

            return worksheet;
        }
    }
}
