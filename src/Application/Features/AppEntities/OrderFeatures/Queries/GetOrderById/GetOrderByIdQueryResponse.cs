using System;
using Domain.Entities;

namespace Application.Features.AppEntities.OrderFeatures.Queries.GetOrderById
{
	public sealed record GetOrderByIdQueryResponse(
		Order Data
		);

}

