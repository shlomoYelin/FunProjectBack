using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.ExcelModule
{
    public interface IExcelAdapter
    {
        MemoryStream GenerateExcel<T>(IList<T> data, string worksheetName);
    }
}
