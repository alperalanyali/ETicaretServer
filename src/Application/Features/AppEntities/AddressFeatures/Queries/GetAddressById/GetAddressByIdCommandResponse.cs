using System;
using Domain.Entities;

namespace Application.Features.AppEntities.AddressFeatures.Queries.GetAddressById
{
	public sealed record GetAddressByIdCommandResponse(
			Address Data
		);
	
}

