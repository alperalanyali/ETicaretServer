using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.QuantityRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.QuantityTypeRepository
{
    public class QuantityTypeQueryRepository : AppQueryRepository<QuantityType>, IQuantityTypeQueryRepository
    {
        public QuantityTypeQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

