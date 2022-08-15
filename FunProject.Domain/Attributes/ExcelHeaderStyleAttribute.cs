using System;
using System.Drawing;

namespace FunProject.Domain.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ExcelHeaderStyleAttribute: Attribute
    {
        public KnownColor Color { get; set; }
        public bool Bold { get; set; } = true;
        public double Height { get; set; }
    }
}
