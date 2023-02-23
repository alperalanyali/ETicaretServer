using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.AddressRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.AddressesRepository
{
    public class AddresesCommandRepository : AppCommandRepository<Address>,IAddressCommandRepository
    {
        public AddresesCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

