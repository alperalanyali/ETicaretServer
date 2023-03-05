using System;
using Application.Messaging;
using Microsoft.AspNetCore.Http;

namespace Application.Features.AppEntities.ProductFeatures.Commands.UpdateProduct
{
	public sealed record UpdateProductCommand(
			string Id,
			string Code,
			string Name,
            string Description,
            string QuantityTypeId,
			decimal Price,			
			IFormFile ImageUrl			
		):ICommand<UpdateProductCommandResponse>;
	
}

