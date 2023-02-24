using System;
using Domain.Entities;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Queries.GetProductCategoriesByProductId
{
	public sealed record GetProductCategoriesByProductIdQueryResponse(
			int result,
			IList<ProductCategory> Data
		);
	
}

