using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.Data.Products.Query
{
    public interface IGetProductsBySearchValueQuery
    {
        IList<Product> Get(string searchValue);
    }
}
