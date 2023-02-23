using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.BasketItemRepository
{
	public interface IBasketItemQueryRepository :IAppQueryRepository<BasketItem>
	{
	}
}

