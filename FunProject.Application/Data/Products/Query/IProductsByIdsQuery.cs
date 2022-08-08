using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.Data.Products.Query
{
    public interface IProductsByIdsQuery
    {
        IList<Product> Get(IList<int> productsIds);
    }
}
