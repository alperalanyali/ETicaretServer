using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.StoreRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.StoreRepository
{
    public class StoreCommandRepository : AppCommandRepository<Store>, IStoreCommandRepository
    {
        public StoreCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

