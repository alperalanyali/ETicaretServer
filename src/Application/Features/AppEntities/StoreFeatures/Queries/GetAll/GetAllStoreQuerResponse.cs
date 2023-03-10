using System;
using Domain.Entities;

namespace Application.Features.AppEntities.StoreFeatures.Queries.GetAll
{
	public sealed record GetAllStoreQuerResponse(
			int results,
			IList<Store> Data
		);
	
}

