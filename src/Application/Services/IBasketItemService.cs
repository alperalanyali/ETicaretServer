using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IBasketItemService
	{
		Task Create(BasketItem basketItem, CancellationToken cancellationToken);
		Task Update(BasketItem basketItem, CancellationToken cancellationToken);
		Task Delete(string id,CancellationToken cancellationToken);
		Task<IList<BasketItem>> GetAllBasketItem();
		Task<IList<BasketItem>> GetBasketItemByBasketId(string basketId);
		Task<BasketItem> GetById(string id,bool isTracking=false);
		Task DeleteBasketItemByBasketId(IList<BasketItem> basketItems,CancellationToken cancellationToken);

	}
}

