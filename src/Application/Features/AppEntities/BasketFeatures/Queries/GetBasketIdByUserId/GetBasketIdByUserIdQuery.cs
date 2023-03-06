using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketFeatures.Queries.GetBasketIdByUserId
{
	public sealed record GetBasketIdByUserIdQuery(
		string UserId
		):IQuery<GetBasketIdByUserIdQueryResponse>;
	
}

