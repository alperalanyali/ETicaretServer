using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderItemFeatures.Commands.CreateOrderItem
{
	public sealed record CreateOrderItemCommand(
			Guid OrderId,
			Guid ProductId,
			decimal Quantity,
			decimal TotalPrice
		):ICommand<CreateOrderItemCommandResponse>;
	
}

