using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductStoreFeatures.Queries.GetAllProductStore
{
	public sealed record GetAllProductStoreQuery(
		int PagaNumber =1,
		int PageSize = 10
		):IQuery<GetAllProductStoreQueryResponse>;
	
}

