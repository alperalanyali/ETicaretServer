using System;
using Domain.Entities;

namespace Application.Features.AppEntities.OrderItemFeatures.Queries.GetAllOrderItems
{
	public sealed record GetAllOrderItemsQueryResponse(
		int results,
		IList<OrderItem> Data
		);
	
}

