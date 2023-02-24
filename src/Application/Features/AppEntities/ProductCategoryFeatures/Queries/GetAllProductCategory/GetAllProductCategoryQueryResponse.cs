using System;
using Domain.Entities;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Queries.GetAllProductCategory
{
	public sealed record GetAllProductCategoryQueryResponse(
            int results,
            IList<ProductCategory> Data
        );
	
}

