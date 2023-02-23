using System;
using Application.Messaging;

namespace Application.Features.AppEntities.CategoryFeatures.Commands.UpdateCategory
{
	public sealed record UpdateCategoryCommand(
			string Id,
			string Name,
			string Code,
			bool IsActive
		):ICommand<UpdateCategoryCommandResponse>;

}

