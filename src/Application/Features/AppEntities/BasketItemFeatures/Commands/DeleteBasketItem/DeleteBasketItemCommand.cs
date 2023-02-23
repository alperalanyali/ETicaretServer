using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketItemFeatures.Commands.DeleteBasketItem
{
	public sealed record DeleteBasketItemCommand(string Id):ICommand<DeleteBasketItemCommandResponse>;
	
}

