using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Queries.GetAllProductCategory
{
	public sealed record GetAllProductCategoryQuery(
		int PageNumber = 1,
		int PageSize = 10

		):IQuery<GetAllProductCategoryQueryResponse>;
	
}

