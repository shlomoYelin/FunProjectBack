using System;
using System.Drawing;

namespace FunProject.Domain.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ExcelColumnStyleAttribute : Attribute
    {
            public int Index { get; set; }
            public string Name { get; set; }
            public KnownColor Color { get; set; }
            public bool Bold { get; set; }
            public double Width { get; set; }

    }
}
