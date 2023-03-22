using System;
namespace Application.Features.AppEntities.AuthFeatures.Commands.UpdateUser
{
	public sealed record UpdateUserCommandResponse(
		string Message ="Kullanıcı başarılı şekilde güncellendi"
		);
	
}

