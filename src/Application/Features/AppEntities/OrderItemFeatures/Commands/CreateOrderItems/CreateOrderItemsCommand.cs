using System;
using Application.Messaging;
using Domain.Entities;

namespace Application.Features.AppEntities.OrderItemFeatures.Commands.CreateOrderItems
{
	public sealed record CreateOrderItemsCommand(
		List<BasketItem> BasketItems,
		Guid OrderId
		):ICommand<CreateOrderItemsCommandResponse>;
	
}

