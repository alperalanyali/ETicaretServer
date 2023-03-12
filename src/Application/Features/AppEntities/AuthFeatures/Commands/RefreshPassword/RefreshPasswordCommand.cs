using System;
using Application.Messaging;

namespace Application.Features.AppEntities.AuthFeatures.Commands.RefreshPassword
{
	public sealed record RefreshPasswordCommand(
		string Id,
		string Password

		)
		:ICommand<RefreshPasswordCommandResponse>;
	
}

