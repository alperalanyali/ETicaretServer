using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketItemFeatures.Commands.DeleteBasketItemByBasketId
{
	public sealed record DeleteBasketItemByBasketIdCommand(
		string BasketId
		):ICommand<DeleteBasketItemByBasketIdCommandResponse>;
	
}

