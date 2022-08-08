﻿using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.Tasks.Interfaces
{
    public interface ISetAsBlodTask
    {
        ExcelWorksheet Set(ExcelWorksheet worksheet, (int column, int row) startIndex, (int column, int row) endIndex);
    }
}