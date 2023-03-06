using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderFeatures.Commands.CreateOrder
{
	public sealed record CreateOrderCommand(
		Guid Address,
		Guid PaymentTypeId,
		Guid UserId

		):ICommand<CreateOrderCommandResponse>;
	
}

