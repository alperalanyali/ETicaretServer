using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductStoreFeatures.Commands.DeleteProductStore
{
	public sealed record DeleteProductStoreCommand(
		string Id
	):ICommand<DeleteProductStoreCommandResponse>;
	
}

