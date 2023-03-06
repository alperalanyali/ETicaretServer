using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketFeatures.Queries.GetBasketById
{
	public sealed record GetBasketByIdQuery(
		string BasketId
		):IQuery<GetBasketByIdQueryResponse>;
	
}

