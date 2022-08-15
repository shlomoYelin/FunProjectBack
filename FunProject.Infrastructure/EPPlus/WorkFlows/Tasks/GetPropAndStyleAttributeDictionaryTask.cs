using FunProject.Domain.Attributes;
using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks
{
    public class GetPropAndStyleAttributeDictionaryTask : IGetPropAndStyleAttributeDictionaryTask
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
