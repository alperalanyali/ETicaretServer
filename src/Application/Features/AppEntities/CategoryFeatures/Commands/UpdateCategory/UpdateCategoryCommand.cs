using System;
using Application.Messaging;

namespace Application.Features.AppEntities.CategoryFeatures.Commands.UpdateCategory
{
	public sealed record UpdateCategoryCommand(
			string Id,
			int ItemNo,
			string Name,
			string Code,
			bool IsActive
		):ICommand<UpdateCategoryCommandResponse>;

}

