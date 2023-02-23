using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketItemFeatures.Commands.CreateBasketItem
{
	public sealed record CreateBasketItemCommand(
			Guid BasketId,
			Guid ProductId,
			decimal Quantity,
			decimal TotalPrice
		):ICommand<CreateBasketItemCommandResponse>;

}

