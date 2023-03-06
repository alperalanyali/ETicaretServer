using System;
using Domain.Entities.Identity;

namespace Application.Features.AppEntities.AuthFeatures.Queries.GetUserById
{
	public sealed record GetUserByIdQueryResponse(
		AppUser Data
		);

}

