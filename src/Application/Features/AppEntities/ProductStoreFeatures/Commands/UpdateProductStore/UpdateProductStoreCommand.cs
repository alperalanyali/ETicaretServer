using System;
using Application.Messaging;
using Microsoft.AspNetCore.Http;

namespace Application.Features.AppEntities.ProductStoreFeatures.Commands.UpdateProductStore
{
	public sealed record UpdateProductStoreCommand(
		string Id,
        string StoreId,
        decimal Price,
        string Code,
        string Name,
        string Description,
        IFormFile ImageUrl,
        string QuantityTypeId,
        int InStock
		):ICommand<UpdateProductStoreCommandResponse>;
	
}

