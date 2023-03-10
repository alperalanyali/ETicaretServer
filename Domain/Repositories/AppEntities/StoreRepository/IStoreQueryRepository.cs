using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.StoreRepository
{
	public interface IStoreQueryRepository: IAppQueryRepository<Store>
	{
	}
}

