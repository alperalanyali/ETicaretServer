using System;
using Application.Messaging;

namespace Application.Features.AppEntities.AuthFeatures.Commands.ForgotPassword
{
	public sealed record ForgotPasswordCommand(
		string emailOrUsername
		):ICommand<ForgotPasswordCommandResponse>;

}

