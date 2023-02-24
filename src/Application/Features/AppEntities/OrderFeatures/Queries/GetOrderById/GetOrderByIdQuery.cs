using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderFeatures.Queries.GetOrderById
{
	public sealed record GetOrderByIdQuery(
		string Id
		):IQuery<GetOrderByIdQueryResponse>;

}

