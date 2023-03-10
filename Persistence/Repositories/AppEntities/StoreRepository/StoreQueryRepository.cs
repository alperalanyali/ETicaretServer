using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.StoreRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.StoreRepository
{
    public class StoreQueryRepository : AppQueryRepository<Store>, IStoreQueryRepository
    {
        public StoreQueryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

