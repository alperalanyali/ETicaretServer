using System;
using Application.Messaging;

namespace Application.Features.AppEntities.UserFeatures.Queries.GetAllUser
{
	public sealed record GetAllUserQuery(
		int PageNumber = 1,
		int PageSize = 10
		):IQuery<GetAllUserQueryResponse>;
	
}

