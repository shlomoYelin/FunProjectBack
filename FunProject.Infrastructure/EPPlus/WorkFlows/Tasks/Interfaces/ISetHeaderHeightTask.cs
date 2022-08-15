﻿using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface ISetHeaderHeightTask
    {
        ExcelWorksheet Set(ExcelWorksheet worksheet, double height);
    }
}
