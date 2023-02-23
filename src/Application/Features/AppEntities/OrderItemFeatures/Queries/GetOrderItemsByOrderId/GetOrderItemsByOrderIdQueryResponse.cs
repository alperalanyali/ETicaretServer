using System;
using Domain.Entities;

namespace Application.Features.AppEntities.OrderItemFeatures.Queries.GetOrderItemsByOrderId
{
	public sealed record GetOrderItemsByOrderIdQueryResponse(
			bool IsSuccess,
			int results,
			IList<OrderItem> Data
		);
	
}

