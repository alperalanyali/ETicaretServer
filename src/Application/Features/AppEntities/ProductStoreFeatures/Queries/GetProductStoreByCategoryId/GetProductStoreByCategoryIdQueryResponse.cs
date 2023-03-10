using System;
using Domain.Entities;

namespace Application.Features.AppEntities.ProductStoreFeatures.Queries.GetProductStoreByCategoryId
{
	public sealed record GetProductStoreByCategoryIdQueryResponse(
			int Results,
			IList<ProductStore> Data
		);


}

