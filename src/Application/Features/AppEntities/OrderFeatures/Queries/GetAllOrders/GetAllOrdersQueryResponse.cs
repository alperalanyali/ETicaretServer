using System;
using Domain.Entities;

namespace Application.Features.AppEntities.OrderFeatures.Queries.GetAllOrders
{
	public sealed record GetAllOrdersQueryResponse(
		bool IsSuccess,
		int results,
		IList<Order> Data
		);
	
}

