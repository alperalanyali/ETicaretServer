using System;
namespace Application.Features.AppEntities.ProductCategoryFeatures.Commands.CreateProductCategory
{
	public sealed record CreateProductCategoryCommandResponse(
		string Message = "Ürüne kategori başarılı şekilde eklenmiştir"
		);
	
}

