using System;
using Domain.Entities.Identity;

namespace Application.Features.AppEntities.RoleFeatures.Queries.GetAllRole
{
	public sealed record GetAllRoleQueryResponse(
		int results,
		IList<AppRole> Data
		);
	
}

