using System;
using Domain.Entities;

namespace Application.Features.AppEntities.BasketFeatures.Queries.GetBasketIdByUserId
{
	public sealed record GetBasketIdByUserIdQueryResponse(
		bool isSuccess,
		int Result,
		Basket Data

		);
	
}

