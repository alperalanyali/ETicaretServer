using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetProductIdByCodeAndName
{
	public sealed record GetProductByCodeAndNameQuery(
		string Code,
		string Name
		):IQuery<GetProductByCodeAndNameQueryResponse>;

}

