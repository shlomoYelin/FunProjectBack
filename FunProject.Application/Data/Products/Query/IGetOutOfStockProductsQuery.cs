using FunProject.Domain.Models;
using System.Collections.Generic;

namespace FunProject.Application.Data.Products.Query
{
    public interface IGetOutOfStockProductsQuery
    {
        IList<ProductMinimalDetailsModel> Get(IList<int> productsIds);
    }
}
