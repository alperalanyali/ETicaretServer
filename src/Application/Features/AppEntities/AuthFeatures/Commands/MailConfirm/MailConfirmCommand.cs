using System;
using Application.Messaging;

namespace Application.Features.AppEntities.AuthFeatures.Commands.MailConfirm
{
	public sealed record MailConfirmCommand(
		string Code
		):ICommand<MailConfirmResponse>;
	
}

