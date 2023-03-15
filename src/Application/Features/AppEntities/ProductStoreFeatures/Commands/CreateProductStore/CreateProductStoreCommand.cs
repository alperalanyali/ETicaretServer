
using System;
using Application.Messaging;
using Microsoft.AspNetCore.Http;

namespace Application.Features.AppEntities.ProductStoreFeatures.Commands.CreateProductStore
{
	public sealed record CreateProductStoreCommand(
		//string ProductId,
		string StoreId,
		decimal Price,
		string Code,
		string Name,
		string Description,
        IFormFile ImageUrl,
		string QuantityTypeId,
		int InStock
		):ICommand<CreateProductStoreCommandResponse>;
	
}

