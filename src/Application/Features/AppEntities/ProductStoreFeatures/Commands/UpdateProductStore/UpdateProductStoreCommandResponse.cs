using System;
namespace Application.Features.AppEntities.ProductStoreFeatures.Commands.UpdateProductStore
{
	public sealed record UpdateProductStoreCommandResponse(
		string Message = "Ürün başarılı şekilde güncellendi"
		);
	
}

