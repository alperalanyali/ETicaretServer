using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IOrderItemService
	{
		Task Create(OrderItem orderItem, CancellationToken cancellationToken);
		Task Update(OrderItem orderItem, CancellationToken cancellationToken);
		Task Delete(string id, CancellationToken cancellationToken);
		Task<IList<OrderItem>> GetAllOrderItems();
		Task<OrderItem> GetById(string id);
		Task<IList<OrderItem>> GetOrderItemByOrderId(string orderId);
		Task AddRange(IList<OrderItem> orderItems, CancellationToken cancellationToken);
		Task<decimal> GetTotalPriceByOrderId(string orderId);
	}
}

