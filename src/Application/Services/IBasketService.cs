using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IBasketService
	{
		Task CreateBasket(Basket basket, CancellationToken cancellationToken);
		Task Update(Basket basket, CancellationToken cancellationToken);
		Task Delete(string id, CancellationToken cancellationToken);
		Task<IList<Basket>> GetAllBasket();
		Task<Basket> GetById(string id);
		Task<Basket> GetBasketIdByUserId(string userId);
	}
}

