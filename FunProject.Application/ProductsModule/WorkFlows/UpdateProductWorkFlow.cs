using FunProject.Application.HubModule;
using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.WorkFlows.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Models;
using System.Collections.Generic;

namespace FunProject.Application.ProductsModule.WorkFlows
{
    public class UpdateProductWorkFlow : IUpdateProductWorkFlow
    {
        private readonly IUpdateProductTask _UpdateCustomerTask;
        private readonly IProductsStockHub _productsStockHub;


        public UpdateProductWorkFlow(
            IUpdateProductTask updateProductTask,
            IProductsStockHub productsStockHub)
        {
            _UpdateCustomerTask = updateProductTask;
            _productsStockHub = productsStockHub;
        }

        public ActionStatusModel Update(ProductDto product)
        {
            var actionStatus = new ActionStatusModel { Success = true };

            try
            {
                _UpdateCustomerTask.Update(product);

                _productsStockHub.SendUpdate(new List<ProductDto> { product });
            }
            catch (System.Exception ex)
            {
                actionStatus.Success = false;
                actionStatus.Message = ex.Message;
            }

            return actionStatus;
        }
    }
}
