using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Queries.GetProductCategoriesByProductId
{
	public sealed record GetProductCategoriesByProductIdQuery(
			Guid ProductId
		):IQuery<GetProductCategoriesByProductIdQueryResponse>;
	
}

