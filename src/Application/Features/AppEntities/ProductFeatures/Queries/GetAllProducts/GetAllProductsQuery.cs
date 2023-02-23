using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetAllProducts
{
	public sealed record GetAllProductsQuery():IQuery<GetAllProductsQueryResponse>;
	
}

