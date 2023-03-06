using System;
using Domain.Entities;

namespace Application.Features.AppEntities.BasketFeatures.Queries.GetBasketById
{
	public sealed record GetBasketByIdQueryResponse(
			bool isSuccess,
            int Results,
            Basket Data		
		);
	
}

