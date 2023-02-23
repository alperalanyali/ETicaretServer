using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.ProductRepository
{
	public interface IProductCommandRepository: IAppCommandRepository<Product>
	{
		
	}
}

