using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderFeatures.Commands.CreateOrder
{
	public sealed record CreateOrderCommand(
		Guid BasketId,
		Guid Address,
		Guid PaymentTypeId
		):ICommand<CreateOrderCommandResponse>;
	
}

