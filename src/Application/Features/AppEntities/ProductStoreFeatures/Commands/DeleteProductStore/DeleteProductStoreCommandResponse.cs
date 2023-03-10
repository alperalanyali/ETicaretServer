using System;
namespace Application.Features.AppEntities.ProductStoreFeatures.Commands.DeleteProductStore
{
	public sealed record DeleteProductStoreCommandResponse(
		string Messsage = "Kayıt başarılı şekilde silinmiştir."
		);
	
}

