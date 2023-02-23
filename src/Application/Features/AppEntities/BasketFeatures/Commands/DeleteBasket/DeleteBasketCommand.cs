using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketFeatures.Commands.DeleteBasket
{
	public sealed record DeleteBasketCommand(string Id):ICommand<DeleteBasketCommandResponse>;
	
}

