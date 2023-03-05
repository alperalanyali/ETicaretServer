using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetProductsByCategoryId
{
	public sealed record GetProductsByCategoryIdQuery(
		string CategoryId
		):IQuery<GetProductsByCategoryIdQueryResponse>;
	
}

