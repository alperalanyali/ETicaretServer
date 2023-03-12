using System;
namespace Application.Features.AppEntities.EmailFeatures.Commands.TesEmail
{
	public sealed record TestEmailCommandResponse(
		string Message = "Eposta başarılı şekilde gönderildi",
		bool IsSuccessful = false

		);
	
}

