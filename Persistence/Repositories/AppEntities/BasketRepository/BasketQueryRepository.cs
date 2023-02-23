using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.BasketRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.BasketRepository
{
    public class BasketQueryRepository : AppQueryRepository<Basket>,IBasketQueryRepository
    {
        public BasketQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

