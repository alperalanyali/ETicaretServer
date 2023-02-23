using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderItemFeatures.Queries.GetOrderItemsByOrderId
{
	public sealed record GetOrderItemsByOrderIdQuery(
			string orderId
		):IQuery<GetOrderItemsByOrderIdQueryResponse>;
	
}

