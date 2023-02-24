using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Commands.CreateProductCategory
{
	public sealed record CreateProductCategoryCommand(
		Guid ProductId,
		Guid CategoryId
		):ICommand<CreateProductCategoryCommandResponse>;
	
}

