using System;
using Domain.Entities;

namespace Application.Features.AppEntities.ProductStoreFeatures.Queries.GetAllProductStore
{
	public sealed record GetAllProductStoreQueryResponse(
		int results,
		IList<ProductStore> Data
		);
	
}

