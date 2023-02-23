using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketItemFeatures.Queries.GetBasketItemsByBasketId
{
	public sealed record GetBasketItemsByBasketIdQuery(
		Guid BasketId
		):IQuery<GetBasketItemsByBasketIdQueryResponse>;
	
}

