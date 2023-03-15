using System;
namespace Application.Features.AppEntities.StoreFeatures.Commands.DeleteStore
{
	public sealed record DeleteStoreCommandResponse(
		string Message = "Kayıt başarılı şekilde silindi"
		);
	
}

