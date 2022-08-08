using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Domain.Atrributes
{
    public class DisplaydNameAttribute : Attribute
    {
        public DisplaydNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
