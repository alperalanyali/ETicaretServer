using System;
using Application.Messaging;

namespace Application.Features.AppEntities.CategoryFeatures.Commands.CreateCategory
{
	public sealed record CreateCategoryCommand(
		int ItemNo,
		string Code,
		string Name

		):ICommand<CreateCategoryCommandResponse>;
	
}

