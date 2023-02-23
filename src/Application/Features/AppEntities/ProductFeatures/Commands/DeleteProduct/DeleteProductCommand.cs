using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductFeatures.Commands.DeleteProduct
{
	public sealed record DeleteProductCommand(
		string Id
		):ICommand<DeleteProductCommandResponse>;
	
}

