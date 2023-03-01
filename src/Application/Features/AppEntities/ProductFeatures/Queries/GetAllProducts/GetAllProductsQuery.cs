using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetAllProducts
{
	public sealed record GetAllProductsQuery(
		int PageNumber = 1,
		int PageSize = 10
		):IQuery<GetAllProductsQueryResponse>;
	
}

