using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.ProductRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.ProductRepository
{
    public class ProductQueryRepository : AppQueryRepository<Product>, IProductQueryRepository
    {
        public ProductQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

