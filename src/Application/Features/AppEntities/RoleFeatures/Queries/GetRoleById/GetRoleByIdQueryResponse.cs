using System;
using Domain.Entities.Identity;

namespace Application.Features.AppEntities.RoleFeatures.Queries.GetRoleById
{
	public sealed record GetRoleByIdQueryResponse(
		AppRole role
		);

}

