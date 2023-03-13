using System;
namespace Application.Features.AppEntities.AuthFeatures.Commands.MailConfirmEmail
{
	public sealed record MailConfirmCommandResponse(
		string Message = "Onay epostası gönderilmiştir."
		);
	
}

