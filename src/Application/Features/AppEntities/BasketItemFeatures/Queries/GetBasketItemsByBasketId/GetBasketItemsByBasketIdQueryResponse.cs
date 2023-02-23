using System;
using Domain.Entities;

namespace Application.Features.AppEntities.BasketItemFeatures.Queries.GetBasketItemsByBasketId
{
	public sealed record GetBasketItemsByBasketIdQueryResponse(
			bool IsSuccess,
			int results,
			IList<BasketItem> data
		);
	
}

