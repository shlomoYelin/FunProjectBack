using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.Data.Products.Query
{
    public interface IProductsByOrderIdQuery
    {
        IList<Product> Get(int orderId);
    }
}
