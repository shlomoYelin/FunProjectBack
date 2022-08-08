using FunProject.Application.Data.ActivityLogs.Command;
using FunProject.Application.Data.ActivityLogs.Query;
using FunProject.Application.Data.Customers.Command;
using FunProject.Application.Data.Customers.Query;
using FunProject.Application.Data.Orders.Command;
using FunProject.Application.Data.Orders.Query;
using FunProject.Application.Data.Orders.Query.QueriesPlugins;
using FunProject.Application.Data.ProductOrders.Command;
using FunProject.Application.Data.ProductOrders.Query;
using FunProject.Application.Data.Products.Command;
using FunProject.Application.Data.Products.Query;
using FunProject.Persistence.ActivityLogs.Command;
using FunProject.Persistence.ActivityLogs.Query;
using FunProject.Persistence.Customers.Command;
using FunProject.Persistence.Customers.Query;
using FunProject.Persistence.Orders.Command;
using FunProject.Persistence.Orders.Query;
using FunProject.Persistence.Orders.Query.QueriesPlugins;
using FunProject.Persistence.ProducOrders.Command;
using FunProject.Persistence.ProducOrders.Query;
using FunProject.Persistence.Products.Command;
using FunProject.Persistence.Products.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace FunProject.Persistence
{
    public static class ServicesCollectionExtension
    {
        public static void AddPersistanceLayerServices(this IServiceCollection services)
        {
            //services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("FunProjectDataBase"));
            _ = services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=funDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            //,ServiceLifetime.Transient
            // data services
            _ = services.AddTransient<ISampleData, SampleData>();

            //Querys

            //Customer
            _ = services.AddTransient<IAllCustomersQuery, AllCustomersQuery>();
            _ = services.AddTransient<ICustomerIsExistsQuery, CustomerIsExistsQuery>();
            _ = services.AddTransient<IGetCustomersByIdsQuery, GetCustomersByIdsQuery>();
            _ = services.AddTransient<IGetCustomerTypeQuery, GetCustomerTypeQuery>();
            _ = services.AddTransient<IGetCustomerByIdQuery, GetCustomerByIdQuery>();
            _ = services.AddTransient<ICustomersBySearchValueQuery, CustomersBySearchValueQuery>();

            //Product
            _ = services.AddTransient<IAllProductsQuery, AllProductsQuery>();
            _ = services.AddTransient<IProductIsExistsQuery, ProductIsExistsQuery>();
            _ = services.AddTransient<IGetProductPriceQuery, GetProductPriceQuery>();
            _ = services.AddTransient<IGetProductDescQuery, GetProductDescQuery>();
            _ = services.AddTransient<IGetProductsBySearchValueQuery, GetProductsBySearchValueQuery>();
            _ = services.AddTransient<IProductIsInStockQuery, ProductIsInStockQuery>();
            _ = services.AddTransient<IGetOutOfStockProductsQuery, GetOutOfStockProductsQuery>();
            _ = services.AddTransient<IGetAllOutOfStockProductsQuery, GetAllOutOfStockProductsQuery>();
            _ = services.AddTransient<IProductsByOrderIdQuery, ProductsByOrderIdQuery>();
            _ = services.AddTransient<IProductsByIdsQuery, ProductsByIdsQuery>();

            ////ProductOrder
            _ = services.AddTransient<IProductOrdersByOrderIdQuery, ProductOrdersByOrderIdQuery>();

            //Order
            _ = services.AddTransient<IOrderIsExistsQuery, OrderIsExistsQuery>();
            _ = services.AddTransient<IOrderByIdQuery, OrderByIdQuery>();
            _ = services.AddTransient<IOrderIsExistsByCustomerIdQuery, OrderIsExistsByCustomerIdQuery>();
            _ = services.AddTransient<IOrderIsExistsByProductIdQuery, OrderIsExistsByProductIdQuery>();
            _ = services.AddTransient<IOrdersByFiltersQuery, OrdersByFiltersQuery>();

            //ActivityLog
            _ = services.AddTransient<IAllActivityLogsQuery, AllActivityLogsQuery>();
            _ = services.AddTransient<IAllActivityLogsQuery, AllActivityLogsQuery>();


            //Commands

            //Customer
            _ = services.AddTransient<ICreateCustomerCommand, CreateCustomerCommand>();
            _ = services.AddTransient<IDeleteCustomerCommand, DeleteCustomerCommand>();
            _ = services.AddTransient<IUpdateCustomerCommand, UpdateCustomerCommand>();

            //Product
            _ = services.AddTransient<ICreateProductCommand, CreateProductCommand>();
            _ = services.AddTransient<IDeleteProductCommand, DeleteProductCommand>();
            _ = services.AddTransient<IUpdateProductCommand, UpdateProductCommand>();
            _ = services.AddTransient<IProductStockUpdateCommand, ProductStockUpdateCommand>();
            _ = services.AddTransient<IAddProductsToStockByOrderIdCommand, AddProductsToStockByOrderIdCommand>();

            //ProductOrder
            _ = services.AddTransient<IUpdateProductOrderCommand, UpdateProductOrderCommand>();
            _ = services.AddTransient<ICreateProductOrderCommand, CreateProductOrderCommand>();
            _ = services.AddTransient<IDeleteProductOrderRangeCommand, DeleteProductOrderRangeCommand>();


            //Order
            _ = services.AddTransient<ICreateOrderCommand, CreateOrderCommand>();
            _ = services.AddTransient<IDeleteOrderCommand, DeleteOrderCommand>();
            _ = services.AddTransient<IUpdateOrderCommand, UpdateOrderCommand>();


            //ActivityLog
            _ = services.AddTransient<ICreateActivityLogsCommand, CreateActivityLogCommand>();

            //Query plgins
            _ = services.AddTransient<IFilterOrdersByCustomerNameSearchValue, FilterOrdersByCustomerNameSearchValue>();
            _ = services.AddTransient<IFilterOrdersByCustomerType, FilterOrdersByCustomerType>();
            _ = services.AddTransient<IFilterOrdersByDateRange, FilterOrdersByDateRange>();
            _ = services.AddTransient<IFilterOrdersByProductNameSearchValue, FilterOrdersByProductNameSearchValue>();

        }
    }
}
