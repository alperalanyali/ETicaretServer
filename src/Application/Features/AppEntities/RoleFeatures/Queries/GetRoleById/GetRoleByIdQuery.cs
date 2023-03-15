using System;
using Application.Messaging;

namespace Application.Features.AppEntities.RoleFeatures.Queries.GetRoleById
{
	public sealed record GetRoleByIdQuery(
		string Id
		):IQuery<GetRoleByIdQueryResponse>;
	
}

