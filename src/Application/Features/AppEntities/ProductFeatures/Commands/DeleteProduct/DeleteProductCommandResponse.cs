using System;
namespace Application.Features.AppEntities.ProductFeatures.Commands.DeleteProduct
{
	public sealed record DeleteProductCommandResponse(
		string Message = "Ürün, sistemden başarılı şekilde kaldırıldı"
		);
	
}

