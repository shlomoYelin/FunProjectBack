using System.Collections.Generic;
using System.IO;

namespace FunProject.Domain.ExcelModule
{
    public interface IExcelAdapter
    {
        MemoryStream GenerateExcel<T>(IList<T> data, string worksheetName);
    }
}
