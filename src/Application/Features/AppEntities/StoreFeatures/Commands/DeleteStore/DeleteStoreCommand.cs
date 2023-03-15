using System;
using Application.Messaging;

namespace Application.Features.AppEntities.StoreFeatures.Commands.DeleteStore
{
	public sealed record DeleteStoreCommand(
		string Id
		):ICommand<DeleteStoreCommandResponse>;
	
}

