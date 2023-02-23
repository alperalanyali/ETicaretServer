using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.QuantityRepository
{
	public interface IQuantityCommandRepository:IAppCommandRepository<QuantityType>
	{
	}
}

