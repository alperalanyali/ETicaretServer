using System;
namespace Application.Features.AppEntities.StoreFeatures.Commands.UpdateStore
{
	public sealed record UpdateStoreCommandResponse(
		string Message = "Sanal Dükkan başarılı şekilde güncellenmiştir"
		);
	
}

