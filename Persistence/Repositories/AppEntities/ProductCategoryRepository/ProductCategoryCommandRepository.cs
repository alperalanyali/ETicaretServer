using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.ProductCategoryRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.ProductCategoryRepository
{
    public class ProductCategoryCommandRepository : AppCommandRepository<ProductCategory>, IProductCategoryCommandRepository
    {
        public ProductCategoryCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

