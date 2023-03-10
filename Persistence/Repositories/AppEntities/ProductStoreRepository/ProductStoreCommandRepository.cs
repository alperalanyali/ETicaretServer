using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.ProductStoreRepository;
using Domain.Repository.GenericRepositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.ProductStoreRepository
{
    public class ProductStoreCommandRepository : AppCommandRepository<ProductStore>,IProductStoreCommandRepository
    {
        public ProductStoreCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        
    }
}

