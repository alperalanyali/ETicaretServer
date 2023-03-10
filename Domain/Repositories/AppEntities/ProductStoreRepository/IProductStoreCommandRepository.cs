using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.ProductStoreRepository
{
	public interface IProductStoreCommandRepository: IAppCommandRepository<ProductStore>
    {
	}
}

