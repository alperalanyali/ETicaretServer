using System;
namespace Application.Features.AppEntities.AuthFeatures.Commands.CreateUser
{
	public sealed record CreateUserCommandResponse(
		bool IsSuccess = false,
		string Message = "Kullanıcı başarılı şekilde oluşturuldu"
		);
	
}

