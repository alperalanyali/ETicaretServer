using System;
using Domain.Entities.Identity;

namespace Application.Features.AppEntities.UserFeatures.Queries.GetAllUser
{
	public sealed record GetAllUserQueryResponse(
		int results,
		IList<AppUser> Data
		);
	
}

