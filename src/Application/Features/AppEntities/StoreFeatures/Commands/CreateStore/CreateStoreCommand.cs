using System;
using Application.Messaging;

namespace Application.Features.AppEntities.StoreFeatures.Commands.CreateStore
{
	public sealed record CreateStoreCommand(
		string StoreName,
		string Address
		):ICommand<CreateStoreCommandResponse>;

}

