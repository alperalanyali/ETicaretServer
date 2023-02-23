using System;
using Domain.Entities;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetAllProducts
{
	public sealed record GetAllProductsQueryResponse(
			bool IsSuccess,
			int results,
			IList<Product> Data
		);

}

