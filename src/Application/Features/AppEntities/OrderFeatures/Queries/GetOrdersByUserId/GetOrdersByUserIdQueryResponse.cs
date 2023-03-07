using System;
using Domain.Entities;

namespace Application.Features.AppEntities.OrderFeatures.Queries.GetOrdersByUserId
{
	public sealed record GetOrdersByUserIdQueryResponse(
			bool isSuccess,
			int results,
			IList<Order> Data
		);

}

