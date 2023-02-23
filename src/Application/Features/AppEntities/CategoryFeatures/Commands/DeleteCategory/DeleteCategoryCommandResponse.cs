using System;
namespace Application.Features.AppEntities.CategoryFeatures.Commands.DeleteCategory
{
	public sealed record DeleteCategoryCommandResponse(
		string Message = "Kayıt Silinmiştir"
		);
	
}

