using System;
using Application.Messaging;

namespace Application.Features.AppEntities.OrderFeatures.Queries.GetLastOrderByUserId
{
	public sealed record GetLastOrderByUserIdQuery(
		Guid UserId
		):IQuery<GetLastOrderByUserIdQueryResponse>;
	
}

