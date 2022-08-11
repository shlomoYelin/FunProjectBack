using FunProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Domain.Atrributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ExcelColumnStyleAttribute: Attribute
    {
        //public ExcelColumnStyleAttribute(ExcelColumnStyleModel columnStyle)
        //{
        //    ColumnStyle = columnStyle;
        //}

        //public ExcelColumnStyleModel ColumnStyle { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public KnownColor Color { get; set; }
        public bool Bold { get; set; }
        public double Width { get; set; }

    }
}
