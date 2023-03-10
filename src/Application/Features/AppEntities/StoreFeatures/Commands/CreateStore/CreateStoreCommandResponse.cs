using System;
namespace Application.Features.AppEntities.StoreFeatures.Commands.CreateStore
{
	public sealed record CreateStoreCommandResponse(
		string Message = "Sanal Dükkan başarılı şekilde oluşturuldu"
		);
	
}

