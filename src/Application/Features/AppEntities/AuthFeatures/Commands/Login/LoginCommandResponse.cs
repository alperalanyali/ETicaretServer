using System;
namespace Application.Features.AppEntities.AuthFeatures.Commands.Login
{
	public sealed record LoginCommandResponse(
		string Email,
		Guid UserId,
		string FullName
		);
	
}

