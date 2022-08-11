using FunProject.Domain.Atrributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces
{
    public interface IGetPropAndStyleAtrributeDictionaryTask
    {
        Dictionary<PropertyInfo, ExcelColumnStyleAttribute> Get<T>();
    }
}
