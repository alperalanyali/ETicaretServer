using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductFeatures.Commands.UpdateProduct
{
	public sealed record UpdateProductCommand(
			string Id,
			string Code,
			string Name,
			Guid QuantityTypeId,
			decimal Price,
			string ImageUrl			
		):ICommand<UpdateProductCommandResponse>;
	
}

