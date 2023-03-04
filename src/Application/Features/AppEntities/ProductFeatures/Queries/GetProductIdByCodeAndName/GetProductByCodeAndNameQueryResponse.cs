using System;
using Domain.Entities;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetProductIdByCodeAndName
{
	public sealed record GetProductByCodeAndNameQueryResponse(
		Product Data
		);
	
}

