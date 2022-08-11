using System;

namespace FunProject.Domain.Atrributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplaydNameAttribute : Attribute
    {
        public DisplaydNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
