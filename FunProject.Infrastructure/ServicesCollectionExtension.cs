using FunProject.Application.ActivityLogModule.Services;
using FunProject.Application.ActivityLogModule.Services.Interfaces;
using FunProject.Application.CustomersModule.Services;
using FunProject.Application.CustomersModule.Services.Interfaces;
using FunProject.Application.CustomersModule.Validators;
using FunProject.Application.CustomersModule.Validators.Interfaces;
using FunProject.Application.CustomersModule.Validators.Validations;
using FunProject.Application.CustomersModule.Validators.Validations.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows;
using FunProject.Application.CustomersModule.WorkFlows.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows.Tasks;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.HubModule;
using FunProject.Application.OrdersModule.Factorys;
using FunProject.Application.OrdersModule.Factorys.Interfaces;
using FunProject.Application.OrdersModule.Services;
using FunProject.Application.OrdersModule.Services.Interfaces;
using FunProject.Application.OrdersModule.Validators;
using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.OrdersModule.Validators.Validations;
using FunProject.Application.OrdersModule.Validators.Validations.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.ProductsModule.Services;
using FunProject.Application.ProductsModule.Services.Interfaces;
using FunProject.Application.ProductsModule.Validators;
using FunProject.Application.ProductsModule.Validators.Interfaces;
using FunProject.Application.ProductsModule.Validators.Validations;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows;
using FunProject.Application.ProductsModule.WorkFlows.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Tasks;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.ExcelModule;
using FunProject.Domain.Logger;
using FunProject.Domain.Mapper;
using FunProject.Infrastructure.EPPlus;
using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks;
using FunProject.Infrastructure.EPPlus.WorkFlows.Tasks.Interfaces;
using FunProject.Infrastructure.Logger;
using FunProject.Infrastructure.Mapper;
using FunProject.Infrastructure.SignalR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FunProject.Infrastructure
{
    public static class ServicesCollectionExtension
    {
        public static void AddInrustractureLayerServices(this IServiceCollection services)
        {
            _ = services.AddAutoMapper(Assembly.GetExecutingAssembly());

            _ = services.AddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
            _ = services.AddSingleton<IMapperAdapter, MapperAdapter>();
            _ = services.AddSingleton<IProductsStockHub, StockHub>();

            //appliction Tasks

            //Customer
            _ = services.AddTransient<ICreateCustomerTask, CreateCustomerTask>();
            _ = services.AddTransient<IDeleteCustomerTask, DeleteCustomerTask>();
            _ = services.AddTransient<IGetAllCustomersTask, GetAllCustomersTask>();
            _ = services.AddTransient<IUpdateCustomerTask, UpdateCustomerTask>();
            _ = services.AddTransient<IGetCustomersByIdsTask, GetCustomersByIdsTask>();
            _ = services.AddTransient<IGetCustomerTypeTask, GetCustomerTypeTask>();
            _ = services.AddTransient<IGetCustomersBySearchValueTask, GetCustomersBySearchValueTask>();


            //Product
            _ = services.AddTransient<ICreateProductTask, CreateProductTask>();
            _ = services.AddTransient<IGetAllProductsTask, GetAllProductsTask>();
            _ = services.AddTransient<IUpdateProductTask, UpdateProductTask>();
            _ = services.AddTransient<IDeleteProductTask, DeleteProductTask>();
            _ = services.AddTransient<IGetProductsBySearchValueTask, GetProductsBySearchValueTask>();
            _ = services.AddTransient<IProductIsInStockTask, ProductIsInStockTask>();
            _ = services.AddTransient<IGetAllOutOfStockProductsTask, GetAllOutOfStockProductsTask>();

            //ProductOrder



            //Order
            _ = services.AddTransient<ICreateOrderTask, CreateOrderTask>();
            _ = services.AddTransient<IOrdersByFiltersTask, OrdersByFiltersTask>();
            _ = services.AddTransient<IDeleteOrderTask, DeleteOrderTask>();
            _ = services.AddTransient<IGetOrderByIdTask, GetOrderByIdTask>();
            _ = services.AddTransient<IUpdateOrderTask, UpdateOrderTask>();
            _ = services.AddTransient<IDeleteProductOrdersTask, DeleteProductOrdersTask>();
            _ = services.AddTransient<IOrderIsExistsByCustomerIdTask, OrderIsExistsByCustomerIdTask>();

            _ = services.AddTransient<IProductsPriceCalculationTask, ProductsPriceCalculationTask>();
            _ = services.AddTransient<IUserDiscountPercentageFactory, UserDiscountPercentageFactory>();
            _ = services.AddTransient<IGetOrderPaymentByDiscountPercentageTask, GetOrderPaymentByDiscountPercentageTask>();
            _ = services.AddTransient<IGetProductOrdersByOrderIdTask, GetProductOrdersByOrderIdTask>();
            _ = services.AddTransient<IOrderIsExistsByProductIdTask, OrderIsExistsByProductIdTask>();
            _ = services.AddTransient<IProductOrderGetActionTypeTask, ProductOrderGetActionTypeTask>();
            _ = services.AddTransient<IGetProductOrdersToDeleteTask, GetProductOrdersToDeleteTask>();
            _ = services.AddTransient<ICreateProductOrderTask, CreateProductOrderTask>();
            _ = services.AddTransient<IUpdateProductOrderTask, UpdateProductOrderTask>();
            _ = services.AddTransient<IAddProductsToStockTask, AddProductsToStockTask>();
            _ = services.AddTransient<IRemoveProductsFromStockTask, RemoveProductsFromStockTask>();
            _ = services.AddTransient<IAddProductsToStockByOrderIdTask, AddProductsToStockByOrderIdTask>();
            _ = services.AddTransient<IAddProductsToStockByOrderIdTask, AddProductsToStockByOrderIdTask>();
            _ = services.AddTransient<IProductStockUpdateTask, ProductStockUpdateTask>();
            _ = services.AddTransient<IGetAllOrderQueryPlginsTask, GetAllOrderQueryPlginsTask>();
            _ = services.AddTransient<IGetProductsByOrderIdTask, GetProductsByOrderIdTask>();
            _ = services.AddTransient<IGetProductsByIdsTask, GetProductsByIdsTask>();
            _ = services.AddTransient<IGetAllOrderQueryPlginsTask, GetAllOrderQueryPlginsTask>();
            _ = services.AddTransient<IMergeProductsOrdersIdsTask, MergeProductsOrdersIdsTask>();


            //application work flows 

            //Customer
            _ = services.AddTransient<ICreateCustomerWorkFlow, CreateCustomerWorkFlow>();
            _ = services.AddTransient<IGetAllCustomersWorkFlow, GetAllCustomersWorkFlow>();
            _ = services.AddTransient<IUpdateCustomerWorkFlow, UpdateCustomerWorkFlow>();
            _ = services.AddTransient<IDeleteCustomerWorkFlow, DeleteCustomerWorkFlow>();
            _ = services.AddTransient<IGetCustomersBySearchValueWorkFlow, GetCustomersBySearchValueWorkFlow>();


            //Product
            _ = services.AddTransient<ICreateProductWorkFlow, CreateProductWorkFlow>();
            _ = services.AddTransient<IGetAllProductWorkFlow, GetAllProductsWorkFlow>();
            _ = services.AddTransient<IUpdateProductWorkFlow, UpdateProductWorkFlow>();
            _ = services.AddTransient<IDeleteProductWorkFlow, DeleteProductWorkFlow>();
            _ = services.AddTransient<IGetProductsBySearchValueWorkFlow, GetProductsBySearchValueWorkFlow>();
            _ = services.AddTransient<IProductIsInStockWprkFlow, ProductIsInStockWprkFlow>();
            _ = services.AddTransient<IGetOutOfStockProductsWorkFlow, GetOutOfStockProductsWorkFlow>();

            //ProductOrder


            //Order
            _ = services.AddTransient<ICreateOrderWorkFlow, CreateOrderWorkFlow>();
            _ = services.AddTransient<IDeleteOrderWorkFlow, DeleteOrderWorkFlow>();
            _ = services.AddTransient<IGetOrderByIdWorkFlow, GetOrderByIdWorkFlow>();
            _ = services.AddTransient<IUpdateOrderWorkFlow, UpdateOrderWorkFlow>();
            _ = services.AddTransient<IOrderPaymentCalculationWorkFlow, OrderPaymentCalculationWorkFlow>();
            _ = services.AddTransient<IGetOrdersByFiltersWorkFlow, GetOrdersByFiltersWorkFlow>();
            _ = services.AddTransient<IGetOrdersByFiltersAsExcelWorkFlow, GetOrdersByFiltersAsExcelWorkFlow>();



            // application validations

            //Custoer
            _ = services.AddTransient<ICustomeRequiredValidation, CustomeRequiredValidation>();
            _ = services.AddTransient<ICustomerIsExistsValidation, CustomerIsExistsValidation>();

            //Product
            _ = services.AddTransient<IProductIsExistsValidation, ProductIsExistsValidataion>();
            _ = services.AddTransient<IProductsIsExistsValidation, ProductsIsExistsValidation>();
            _ = services.AddTransient<IProductRequierdValidation, ProductRequierdValidation>();
            _ = services.AddTransient<IProductIsInStockValidation, ProductIsInStockValidation>();

            //Order
            _ = services.AddTransient<IOrderIsExistsValidation, OrderIsExistsValidation>();




            // application validators

            //Customer
            _ = services.AddTransient<IUpdateCustomerValidator, UpdateCustomerValidator>();
            _ = services.AddTransient<ICreateCustomerValidator, CreateCustomerValidator>();
            _ = services.AddTransient<IDeleteCustomerValidator, DeleteCustomerValidator>();


            //Order
            _ = services.AddTransient<ICreateOrderValidator, CreateOrderValidator>();
            _ = services.AddTransient<IDeleteOrderValidator, DeleteOrderValidator>();
            _ = services.AddTransient<IUpdateOrderValidator, UpdateOrderValidator>();


            //Product
            _ = services.AddTransient<ICreateProductValidator, CreateProductValidator>();
            _ = services.AddTransient<IUpdateProductValidator, UpdateProductValidator>();
            _ = services.AddTransient<IDeleteProductValidator, DeleteProductValidator>();



            // application services 
            _ = services.AddTransient<ICustomersService, CustomersService>();
            _ = services.AddTransient<IProductsService, ProductsService>();
            _ = services.AddTransient<IOrdersService, OrdersService>();
            _ = services.AddTransient<IActivityLogService, ActivityLogService>();

            _ = services.AddTransient<IOrderPaymentCalculationService, OrderPaymentCalculationService>();


            //infrastructure 

            //EPPlus
            _ = services.AddTransient<IExcelAdapter, ExcelAdapter>();

            //Tasks
            _ = services.AddTransient<ISetAsBlodTask, SetAsBlodTask>();
            _ = services.AddTransient<IAddRowsToSheetTask, AddRowsToSheetTask>();
            _ = services.AddTransient<ISetColumnsNamesToSheetTask, SetColumnsNamesToSheetTask>();

        }
    }
}
