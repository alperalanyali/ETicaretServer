using System;
using Application.Messaging;
using Microsoft.AspNetCore.Http;

namespace Application.Features.AppEntities.ProductFeatures.Commands.CreateProduct
{
	public sealed record CreateProductCommand(
		string Code,
		string Name,
		string QuantityTypeId,
		IFormFile ImageUrl,
		string Description,
		decimal Price		
		):ICommand<CreateProductCommandResponse>;
	
}

