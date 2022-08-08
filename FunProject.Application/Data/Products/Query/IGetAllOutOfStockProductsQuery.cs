using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.Data.Products.Query
{
    public interface IGetAllOutOfStockProductsQuery
    {
        IList<Product> Get();
    }
}
