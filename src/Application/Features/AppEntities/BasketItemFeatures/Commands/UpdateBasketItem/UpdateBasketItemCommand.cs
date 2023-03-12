using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketItemFeatures.Commands.UpdateBasketItem
{
	public sealed record UpdateBasketItemCommand(
			string Id,
			Guid ProductStoreId,
			Guid BasketId,
			decimal Quantity,
			decimal TotalPrice
		):ICommand<UpdateBasketItemCommandResponse>;
	
}

