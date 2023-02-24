using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Queries.GetProductCategoriesByCategoryId
{
	public sealed record GetProductCategoriesByCategoryIdQuery(
		Guid CategoryId
		):IQuery<GetProductCategoriesByCategoryIdQueryResponse>;
	
}

