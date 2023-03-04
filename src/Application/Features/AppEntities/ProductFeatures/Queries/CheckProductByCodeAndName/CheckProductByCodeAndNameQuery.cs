using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ProductFeatures.Queries.CheckProductByCodeAndName
{
	public sealed record CheckProductByCodeAndNameQuery(
		string Code,
		string Name
		):IQuery<CheckProductByCodeAndNameQueryResponse>;
	
}

