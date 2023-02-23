using System;
using Domain.Entities;

namespace Application.Features.AppEntities.CategoryFeatures.Commands.CreateCategory
{
	public sealed record CreateCategoryCommandResponse(
			bool IsSuccess,
			string Message,
			Category data
		);
	
}

