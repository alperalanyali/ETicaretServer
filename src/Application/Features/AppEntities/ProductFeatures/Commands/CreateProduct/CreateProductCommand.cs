using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductFeatures.Commands.CreateProduct
{
	public sealed record CreateProductCommand(
		string Code,
		string Name,
		Guid QuantityTypeId,
		string ImageUrl,
		decimal Price		
		):ICommand<CreateProductCommandResponse>;
	
}

