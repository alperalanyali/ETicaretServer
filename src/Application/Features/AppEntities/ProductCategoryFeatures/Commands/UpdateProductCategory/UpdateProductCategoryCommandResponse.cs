using System;
namespace Application.Features.AppEntities.ProductCategoryFeatures.Commands.UpdateProductCategory
{
	public sealed record UpdateProductCategoryCommandResponse(
		string Message = "Kayıt başarılı şekilde güncellendi"
		);
	
}

