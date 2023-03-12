using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderItemFeatures.Commands.UpdateOrderItem
{
	public sealed record UpdateOrderItemCommand(
			string Id,
			Guid ProductStoreId,
			decimal Quantity,
			decimal TotalPrice,
			Guid OrderId
		):ICommand<UpdateOrderItemCommandResponse>;

}

