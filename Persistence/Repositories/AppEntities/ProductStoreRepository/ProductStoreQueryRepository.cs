using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.ProductStoreRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.ProductStoreRepository
{
    public class ProductStoreQueryRepository : AppQueryRepository<ProductStore>, IProductStoreQueryRepository
    {
        public ProductStoreQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

