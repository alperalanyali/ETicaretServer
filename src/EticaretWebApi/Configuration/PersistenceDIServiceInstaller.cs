using System;
using Application.Services;
using Domain.Repositories.AppEntities.AddressRepository;
using Domain.Repositories.AppEntities.BasketItemRepository;
using Domain.Repositories.AppEntities.BasketRepository;
using Domain.Repositories.AppEntities.CategoryRepository;
using Domain.Repositories.AppEntities.OrderItemRepository;
using Domain.Repositories.AppEntities.OrderRepository;
using Domain.Repositories.AppEntities.PaymentTypeRepository;
using Domain.Repositories.AppEntities.ProductCategoryRepository;
using Domain.Repositories.AppEntities.ProductRepository;
using Domain.Repositories.AppEntities.QuantityRepository;
using Domain.UnitOfWork;
using OnlineMuhasebeServer.Webapi.Configurations;
using Persistence.Repositories.AppEntities.AddressesRepository;
using Persistence.Repositories.AppEntities.BasketItemRepository;
using Persistence.Repositories.AppEntities.BasketRepository;
using Persistence.Repositories.AppEntities.CategoryRepository;
using Persistence.Repositories.AppEntities.OrderItemRepository;
using Persistence.Repositories.AppEntities.OrderRepository;
using Persistence.Repositories.AppEntities.PaymentTypeRepository;
using Persistence.Repositories.AppEntities.ProductCategoryRepository;
using Persistence.Repositories.AppEntities.ProductRepository;
using Persistence.Repositories.AppEntities.QuantityTypeRepository;
using Persistence.Services.AppEntities;
using Persistence.UnitOfWorks;

namespace EticaretWebApi.Configuration
{
    public class PersistenceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IAppUnitOfWork, AppDbUnitOfWork>();

            #region Service
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IAddresesService, AddressService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IBasketItemService, BasketItemService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderItemService, OrderItemService>();
            services.AddScoped<IPaymentTypeService, PaymentTypeService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IQuantityTypeService, QuantityTypeService>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();
            #endregion

            #region Repositories
            services.AddScoped<IAddressCommandRepository, AddresesCommandRepository>();
            services.AddScoped<IAddressQueryRepository, AddressesQueryRepository>();
            services.AddScoped<IBasketCommandRepository, BasketCommandRepository>();
            services.AddScoped<IBasketQueryRepository, BasketQueryRepository>();
            services.AddScoped<IBasketItemCommandRepository, BasketItemCommandRepository>();
            services.AddScoped<IBasketItemQueryRepository, BasketItemQueryRepository>();
            services.AddScoped<ICategoryCommandRepository, CategoryCommandRepository>();
            services.AddScoped<ICategoryQueryRepository, CategoryQueryRepository>();
            services.AddScoped<IOrderCommandRepository, OrderCommandRepository>();
            services.AddScoped<IOrderQueryRepository,OrderQueryRepository>();
            services.AddScoped<IOrderItemCommandRepository, OrderItemCommandRepository>();
            services.AddScoped<IOrderItemQueryRepository,OrderItemQueryRepository>();
            services.AddScoped<IPaymentTypeCommandRepository, PaymentTypeCommandRepository>();
            services.AddScoped<IPaymentTypeQueryRepository, PaymentTypeQueryRepository>();
            services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
            services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
            services.AddScoped<IProductCategoryCommandRepository, ProductCategoryCommandRepository>();
            services.AddScoped<IProductCategoryQueryRepository, ProductCategoryQueryRepository>();
            services.AddScoped<IQuantityCommandRepository, QuantityCommandRepository>();
            services.AddScoped<IQuantityTypeQueryRepository, QuantityTypeQueryRepository>();
            #endregion
        }
    }
}

