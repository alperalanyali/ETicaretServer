using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketFeatures.Queries.GetBasketCountByUserId
{
	public sealed record GetBasketCountByUserIdQuery(
		string UserId
		):IQuery<GetBasketCountByUserIdQueryResponse>;
	
}

