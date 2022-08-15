using FunProject.Domain.Attributes;
using System.Collections.Generic;
using System.Reflection;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface IGetPropAndStyleAttributeDictionaryTask
    {
        Dictionary<PropertyInfo, ExcelColumnStyleAttribute> Get<T>();
    }
}
