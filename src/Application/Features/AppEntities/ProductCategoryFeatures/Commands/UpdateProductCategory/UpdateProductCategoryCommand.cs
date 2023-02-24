using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Commands.UpdateProductCategory
{
	public sealed record UpdateProductCategoryCommand(
		string Id,
		Guid ProductId,
		Guid CategoryId
		):ICommand<UpdateProductCategoryCommandResponse>;

}

