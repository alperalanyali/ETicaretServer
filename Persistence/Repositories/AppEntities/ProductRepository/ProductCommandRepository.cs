using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.ProductRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.ProductRepository
{
    public class ProductCommandRepository : AppCommandRepository<Product>, IProductCommandRepository
    {
        public ProductCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

