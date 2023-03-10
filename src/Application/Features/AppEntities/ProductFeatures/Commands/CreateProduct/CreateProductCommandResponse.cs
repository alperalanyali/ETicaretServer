using System;
namespace Application.Features.AppEntities.ProductFeatures.Commands.CreateProduct
{
	public sealed record CreateProductCommandResponse(
			string Data,
			string Message = "Ürün başarılı şekilde sisteme eklenmiştir"
		);
	
}

