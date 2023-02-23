using System;
using Application.Messaging;

namespace Application.Features.AppEntities.AuthFeatures.Commands.CreateUser
{
	public sealed record CreateUserCommand(
		string Username,
		string Email,
		string FullName,
		string Password
		):ICommand<CreateUserCommandResponse>;
	
}

