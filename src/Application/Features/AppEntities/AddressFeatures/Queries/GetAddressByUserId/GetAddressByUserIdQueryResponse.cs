using System;
using Domain.Entities;

namespace Application.Features.AppEntities.AddressFeatures.Queries.GetAddressByUserId
{
	public sealed record GetAddressByUserIdQueryResponse(
		int results,
		IList<Address> Data
		);
	
}

