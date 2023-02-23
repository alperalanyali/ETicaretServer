using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderFeatures.Commands.UpdateOrder
{
	public sealed record UpdateOrderCommand(
		string Id,
		Guid  AddressId,
		Guid PaymentId,
		Guid BasketId
		):ICommand<UpdateOrderCommandResponse>;
	
}

