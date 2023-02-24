using System;
namespace Application.Features.AppEntities.ProductCategoryFeatures.Commands.DeleteProductCategory
{
	public sealed record DeleteProductCategoryCommandResponse(
		string Message = "Kayıt silindi"
		);

}
