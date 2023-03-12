using System;
namespace Application.Features.AppEntities.AuthFeatures.Commands.RefreshPassword
{
	public sealed record RefreshPasswordCommandResponse(
		string Message = "Şifreniz başarılı şekilde değiştirilmiştir"
		);
	
}

