using FunProject.Application.HubModule;
using FunProject.Application.ProductsModule.Dtos;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace FunProject.Infrastructure.SignalR
{
    public class StockHub : Hub, IProductsStockHub
    {
        private readonly IHubContext<StockHub> _hub;

        public StockHub(IHubContext<StockHub> hub)
        {
            _hub = hub;
        }

        public void SendUpdate(IList<ProductDto> products)
        {
            _ = _hub.Clients.All.SendAsync("sendupdate", products);
        }
    }
}
