using System;
using Application.Messaging;

namespace Application.Features.AppEntities.AuthFeatures.Commands.MailConfirmEmail
{
	public sealed record SendMailConfirmCommand(
		string emailOrUsername
		):ICommand<MailConfirmCommandResponse>;
	
}

