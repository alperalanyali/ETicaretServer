using System;
using Domain.Entities;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Queries.GetProductCategoriesByCategoryId
{
	public sealed record GetProductCategoriesByCategoryIdQueryResponse(
		int results,
		IList<ProductCategory> Data
		);
	
}

