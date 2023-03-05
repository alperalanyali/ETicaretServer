using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetProductById
{
	public sealed record GetProductByIdQuery(
		string Id
		):IQuery<GetProductByIdQueryResponse>;
	
}

