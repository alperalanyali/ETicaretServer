using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderItemFeatures.Commands.UpdateOrderItem
{
	public sealed record UpdateOrderItemCommand(
			string Id,
			Guid ProductId,
			decimal Quantity,
			decimal TotalPrice,
			Guid OrderId
		):ICommand<UpdateOrderItemCommandResponse>;

}

