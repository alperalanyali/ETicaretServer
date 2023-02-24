using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderFeatures.Queries.GetAllOrders
{
	public sealed record GetAllOrdersQuery():IQuery<GetAllOrdersQueryResponse>;
	
}

