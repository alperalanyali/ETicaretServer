using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderFeatures.Queries.GetOrdersByUserId
{
	public sealed record GetOrdersByUserIdQuery(
		string UserId
		):IQuery<GetOrdersByUserIdQueryResponse>;
	
}

