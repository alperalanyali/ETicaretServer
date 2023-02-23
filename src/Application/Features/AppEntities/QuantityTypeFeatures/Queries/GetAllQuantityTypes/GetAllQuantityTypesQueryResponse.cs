using System;
using Domain.Entities;

namespace Application.Features.AppEntities.QuantityTypeFeatures.Queries.GetAllQuantityTypes
{
	public sealed record GetAllQuantityTypesQueryResponse(
			int results,
			IList<QuantityType> Data
		);

}

