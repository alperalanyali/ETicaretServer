using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderFeatures.Commands.DeleteOrder
{
	public sealed record DeleteOrderCommand(string Id):ICommand<DeleteOrderCommandResponse>;
	
}

