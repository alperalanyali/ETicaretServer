using System;
using Application.Messaging;

namespace Application.Features.AppEntities.CategoryFeatures.Commands.DeleteCategory
{
	public sealed record DeleteCategoryCommand(
		string Id
		):ICommand<DeleteCategoryCommandResponse>;
	
}

