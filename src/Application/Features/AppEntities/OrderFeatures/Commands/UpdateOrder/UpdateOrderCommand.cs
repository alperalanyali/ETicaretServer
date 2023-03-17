using System;
using Application.Messaging;
using Domain.Enums;

namespace Application.Features.AppEntities.OrderFeatures.Commands.UpdateOrder
{
	public sealed record UpdateOrderCommand(
		string Id,
		Guid  AddressId,
		Guid PaymentId,
		Guid BasketId,
		OrderStatus Status
		):ICommand<UpdateOrderCommandResponse>;
	
}

