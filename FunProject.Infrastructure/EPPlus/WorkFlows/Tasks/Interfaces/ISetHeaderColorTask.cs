﻿using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface ISetHeaderColorTask
    {
        ExcelWorksheet Set(ExcelWorksheet worksheet, KnownColor color);
    }
}
