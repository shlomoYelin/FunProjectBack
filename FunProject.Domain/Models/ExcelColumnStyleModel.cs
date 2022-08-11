using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Domain.Models
{
    public class ExcelColumnStyleModel
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public bool Bold { get; set; }
        public double Width { get; set; }

        //public ExcelCellStyleModel(string name, ConsoleColor myProperty, Color myProperty2)
        //{
        //    Name = name;
        //    MyProperty = myProperty;
        //    Color = myProperty2;

        //    myProperty2 = Color.FromName("name");
        //    myProperty2 = Color.FromArgb(0x00, 0x61, 0x00);



        //}
    }
}
