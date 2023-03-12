﻿using System;
using Application.Services;
using Domain.Repositories.AppEntities.AddressRepository;
using Domain.Repositories.AppEntities.BasketItemRepository;
using Domain.Repositories.AppEntities.BasketRepository;
using Domain.Repositories.AppEntities.CategoryRepository;
using Domain.Repositories.AppEntities.ECommercePayments;
using Domain.Repositories.AppEntities.IyzicoSettingRepository;
using Domain.Repositories.AppEntities.OrderItemRepository;
using Domain.Repositories.AppEntities.OrderRepository;
using Domain.Repositories.AppEntities.PaymentTypeRepository;
using Domain.Repositories.AppEntities.ProductCategoryRepository;
using Domain.Repositories.AppEntities.ProductRepository;
using Domain.Repositories.AppEntities.ProductStoreRepository;
using Domain.Repositories.AppEntities.QuantityRepository;
using Domain.Repositories.AppEntities.StoreRepository;
using Domain.UnitOfWork;
using OnlineMuhasebeServer.Webapi.Configurations;
using Persistence.Repositories.AppEntities.AddressesRepository;
using Persistence.Repositories.AppEntities.BasketItemRepository;
using Persistence.Repositories.AppEntities.BasketRepository;
using Persistence.Repositories.AppEntities.CategoryRepository;
using Persistence.Repositories.AppEntities.ECommercePaymentsRepository;
using Persistence.Repositories.AppEntities.IyzicoSettingRepository;
using Persistence.Repositories.AppEntities.OrderItemRepository;
using Persistence.Repositories.AppEntities.OrderRepository;
using Persistence.Repositories.AppEntities.PaymentTypeRepository;
using Persistence.Repositories.AppEntities.ProductCategoryRepository;
using Persistence.Repositories.AppEntities.ProductRepository;
using Persistence.Repositories.AppEntities.ProductStoreRepository;
using Persistence.Repositories.AppEntities.QuantityTypeRepository;
using Persistence.Repositories.AppEntities.StoreRepository;
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
            services.AddScoped<IIyzicoSettingsService, IyzicoSettingService>();
            services.AddScoped<IStoreService, StoreService>();
            services.AddScoped<IProductStore, ProductStoreService>();
            services.AddScoped<IECommercePaymentService, ECommercePaymentService>();
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
            services.AddScoped<IIyzicoSettingCommandRepository, IyzicoSettingCommandRepository>();
            services.AddScoped<IIyzicoSettingQueryRepository, IyzicoSettingQueryRepository>();
            services.AddScoped<IStoreCommandRepository, StoreCommandRepository>();
            services.AddScoped<IStoreQueryRepository, StoreQueryRepository>();
            services.AddScoped<IProductStoreCommandRepository, ProductStoreCommandRepository>();
            services.AddScoped<IProductStoreQueryRepository, ProductStoreQueryRepository>();
            services.AddScoped<IECommercePaymentsCommandRepository, ECommercePaymentCommandRepository>();
            services.AddScoped<IECommercePaymentsQueryRepository, ECommercePaymentQueryRepository>();

            #endregion
        }
    }
}

