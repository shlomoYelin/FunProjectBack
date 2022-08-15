using System.Drawing;

namespace FunProject.Domain.Models
{
    public class ExcelColumnStyleModel
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public bool Bold { get; set; }
        public double Width { get; set; }
    }
}
