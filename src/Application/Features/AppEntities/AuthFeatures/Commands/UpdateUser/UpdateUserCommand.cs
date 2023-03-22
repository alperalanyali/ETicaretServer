using System;
using Application.Messaging;
using Domain.Entities.Identity;

namespace Application.Features.AppEntities.AuthFeatures.Commands.UpdateUser
{
	public sealed record UpdateUserCommand(
			string Id,
			string StoreId
		):ICommand<UpdateUserCommandResponse>;
	
}

