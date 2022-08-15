using OfficeOpenXml;
using System.Drawing;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface ISetColumnColorTask
    {
        ExcelWorksheet Set(ExcelWorksheet worksheet, int index, KnownColor color);
    }
}
