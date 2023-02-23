using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketFeatures.Commands.UpdateBasket
{
	public sealed record UpdateBasketCommand(
		string Id,
		Guid UserId,
		Decimal TotalAmount

		):ICommand<UpdateBasketCommandResponse>;
	
	
}

