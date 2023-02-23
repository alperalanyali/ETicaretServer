using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.AddressRepository
{
	public interface IAddressCommandRepository:IAppCommandRepository<Address>
	{
	}
}

