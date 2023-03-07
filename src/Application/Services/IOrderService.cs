using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IOrderService
	{
		Task Create(Order order, CancellationToken cancellationToken);
		Task Update(Order order, CancellationToken cancellationToken);
		Task Delete(string id, CancellationToken cancellationToken);
		Task<IList<Order>> GetAllOrders();
		Task<Order> GetById(string id);
		Task<Order> GetLastOrderByUserId(Guid userId);
        Task<IList<Order>> GetOrdersByUserId(string userId);
    }
}

