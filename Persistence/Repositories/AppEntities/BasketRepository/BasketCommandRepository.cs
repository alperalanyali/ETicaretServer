using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.BasketRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.BasketRepository
{
    public class BasketCommandRepository : AppCommandRepository<Basket>, IBasketCommandRepository
    {
        public BasketCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

