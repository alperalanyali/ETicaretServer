using System;
namespace Application.Features.AppEntities.CategoryFeatures.Commands.UpdateCategory
{
	public sealed record UpdateCategoryCommandResponse(
			bool IsSucess,
			string Message = "Veri başarılı şekilde güncellenmiştir"
		);
	
}

