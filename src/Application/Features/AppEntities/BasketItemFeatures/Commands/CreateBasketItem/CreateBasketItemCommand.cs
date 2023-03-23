using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketItemFeatures.Commands.CreateBasketItem
{
	public sealed record CreateBasketItemCommand(
			Guid BasketId,
			Guid ProductStoreId,
			int Quantity,
			decimal TotalPrice
		):ICommand<CreateBasketItemCommandResponse>;

}

