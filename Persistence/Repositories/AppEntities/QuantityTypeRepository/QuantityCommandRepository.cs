using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.QuantityRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.QuantityTypeRepository
{
    public class QuantityCommandRepository : AppCommandRepository<QuantityType>, IQuantityCommandRepository
    {
        public QuantityCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

