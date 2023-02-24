using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.ProductCategoryRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.ProductCategoryRepository
{
    public class ProductCategoryQueryRepository : AppQueryRepository<ProductCategory>, IProductCategoryQueryRepository
    {
        public ProductCategoryQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

