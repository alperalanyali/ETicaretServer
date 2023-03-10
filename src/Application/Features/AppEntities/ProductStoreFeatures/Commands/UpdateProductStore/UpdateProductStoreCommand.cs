using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductStoreFeatures.Commands.UpdateProductStore
{
	public sealed record UpdateProductStoreCommand(
		string Id,
		string ProductId,
		string StoreId,
		decimal Price,
		bool UseProductPrice

		):ICommand<UpdateProductStoreCommandResponse>;
	
}

