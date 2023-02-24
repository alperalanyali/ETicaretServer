using System;
using Domain.Entities;

namespace Application.Features.AppEntities.BasketItemFeatures.Queries.GetById
{
	public sealed record GetByIdQueryResponse(
		 BasketItem Data
		);
	
}

