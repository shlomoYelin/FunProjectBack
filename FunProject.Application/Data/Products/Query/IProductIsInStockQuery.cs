namespace FunProject.Application.Data.Products.Query
{
    public interface IProductIsInStockQuery
    {
        public int IsInStock(int productId, int quantity);
    }
}
