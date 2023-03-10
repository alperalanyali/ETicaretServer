using System;
using Application.Messaging;
using Domain.Entities;

namespace Application.Features.AppEntities.StoreFeatures.Commands.UpdateStore
{
	public sealed record UpdateStoreCommand(
		Store store
		):ICommand<UpdateStoreCommandResponse>;
	
}

