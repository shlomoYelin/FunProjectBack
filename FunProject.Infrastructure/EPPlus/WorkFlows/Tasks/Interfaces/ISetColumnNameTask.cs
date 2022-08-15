using OfficeOpenXml;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface ISetColumnNameTask
    {
        ExcelWorksheet Set(ExcelWorksheet worksheet, int rowIndex, int colIndex, string name);
    }
}
