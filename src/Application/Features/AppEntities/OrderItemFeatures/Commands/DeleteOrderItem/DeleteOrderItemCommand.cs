using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderItemFeatures.Commands.DeleteOrderItem
{
	public sealed record DeleteOrderItemCommand(
		string Id
		):ICommand<DeleteOrderItemCommandResponse>;
	
}

