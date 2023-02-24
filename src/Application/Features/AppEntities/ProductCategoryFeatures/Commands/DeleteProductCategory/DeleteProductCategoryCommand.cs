using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Commands.DeleteProductCategory
{
	public sealed record DeleteProductCategoryCommand(string Id):ICommand<DeleteProductCategoryCommandResponse>;
	
}

