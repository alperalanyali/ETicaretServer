
using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductStoreFeatures.Commands.CreateProductStore
{
	public sealed record CreateProductStoreCommand(
		string ProductId,
		string StoreId,
		decimal Price,
		bool UseProductPrice
		):ICommand<CreateProductStoreCommandResponse>;
	
}

