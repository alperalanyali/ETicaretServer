using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductStoreFeatures.Queries.GetProductStoreByCategoryId
{
	public sealed record GetProductStoreByCategoryIdQuery(
		string CategoryId
		):IQuery<GetProductStoreByCategoryIdQueryResponse>;
	
}

