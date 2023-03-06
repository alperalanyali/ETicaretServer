using System;
using Domain.Entities;

namespace Application.Features.AppEntities.OrderFeatures.Queries.GetLastOrderByUserId
{
	public sealed record GetLastOrderByUserIdQueryResponse(
		Order Data
		);
	
}

