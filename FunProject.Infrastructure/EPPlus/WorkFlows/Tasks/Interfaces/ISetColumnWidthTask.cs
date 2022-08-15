using OfficeOpenXml;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface ISetColumnWidthTask
    {
        ExcelWorksheet Set(ExcelWorksheet worksheet, int index, double width);
    }
}
