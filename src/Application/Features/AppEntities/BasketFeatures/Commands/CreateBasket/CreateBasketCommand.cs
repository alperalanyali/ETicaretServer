using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketFeatures.Commands.CreateBasket
{
	public sealed record CreateBasketCommand(
		Guid UserId,
		int Amount,
		decimal TotalAmount


		):ICommand<CreateBasketCommandResponse>;
	
}

