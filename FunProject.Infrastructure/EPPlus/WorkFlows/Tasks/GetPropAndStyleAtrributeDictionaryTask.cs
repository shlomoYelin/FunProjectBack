using FunProject.Domain.Atrributes;
using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class GetPropAndStyleAtrributeDictionaryTask : IGetPropAndStyleAtrributeDictionaryTask
    {
        public Dictionary<PropertyInfo, ExcelColumnStyleAttribute> Get<T>()
        {
            return typeof(T).GetProperties()
                .Where(prop => prop
                    .GetCustomAttributes(typeof(ExcelColumnStyleAttribute), false).Length > 0)

                .Select(prop => 
                new KeyValuePair<PropertyInfo, ExcelColumnStyleAttribute>(
                    prop,
                (ExcelColumnStyleAttribute)prop
                .GetCustomAttributes(typeof(ExcelColumnStyleAttribute), false)
                .First()
                ))

                .OrderBy(prop => prop.Value.Index)

                .ToDictionary(item => item.Key, item => item.Value);
        }
    }
}
