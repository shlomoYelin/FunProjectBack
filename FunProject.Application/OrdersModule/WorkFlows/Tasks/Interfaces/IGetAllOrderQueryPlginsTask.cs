using FunProject.Application.Data.Orders.Query.QueriesPlugins;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetAllOrderQueryPlginsTask
    {
        IList<IBaseOrderQueryPlugin> Get();
    }
}
