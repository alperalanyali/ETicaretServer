using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.BasketItemRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.BasketItemRepository
{
    public class BasketItemCommandRepository : AppCommandRepository<BasketItem>, IBasketItemCommandRepository
    {
        public BasketItemCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

