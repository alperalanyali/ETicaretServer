using System;
using Domain.Entities;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetProductsByCategoryId
{
	public sealed record GetProductsByCategoryIdQueryResponse(	
		bool isSuccess,
		int Results,
        IList<Product> Data
		);
	
}

