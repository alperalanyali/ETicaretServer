using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.AddressRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.AddressesRepository
{
    public class AddressesQueryRepository : AppQueryRepository<Address>,IAddressQueryRepository

    {
        public AddressesQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

