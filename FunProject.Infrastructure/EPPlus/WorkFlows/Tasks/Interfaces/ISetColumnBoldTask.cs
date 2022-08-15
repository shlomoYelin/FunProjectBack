using OfficeOpenXml;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface ISetColumnBoldTask
    {
        ExcelWorksheet Set(ExcelWorksheet worksheet, int index, bool bold);
    }
}
