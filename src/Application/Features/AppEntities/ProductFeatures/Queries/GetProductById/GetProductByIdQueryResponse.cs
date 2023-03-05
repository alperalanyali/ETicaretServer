using System;
using Domain.Entities;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetProductById
{
	public sealed record GetProductByIdQueryResponse(
			Product Data
		);
	
}

