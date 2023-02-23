using System;
namespace Application.Features.AppEntities.ProductFeatures.Commands.UpdateProduct
{
	public sealed record UpdateProductCommandResponse(
		string Message = "Ürünün özellikleri başarılı şekilde güncellenmiştir"
		);
	
}

