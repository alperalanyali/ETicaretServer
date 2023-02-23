using System;
using Application.Messaging;

namespace Application.Features.AppEntities.AuthFeatures.Commands.Login
{
	public sealed record LoginCommand(
		string EmailOrUsername,
		string Password
		):ICommand<LoginCommandResponse>;
	
}

