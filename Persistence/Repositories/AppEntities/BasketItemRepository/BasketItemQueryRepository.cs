using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.BasketItemRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.BasketItemRepository
{
    public class BasketItemQueryRepository : AppQueryRepository<BasketItem>, IBasketItemQueryRepository
    {
        public BasketItemQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

