using OfficeOpenXml;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface ISetAsBlodTask
    {
        ExcelWorksheet Set(ExcelWorksheet worksheet, (int column, int row) startIndex, (int column, int row) endIndex);
    }
}
