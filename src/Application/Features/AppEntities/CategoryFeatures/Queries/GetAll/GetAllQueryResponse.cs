using System;
using Domain.Entities;

namespace Application.Features.AppEntities.CategoryFeatures.Queries.GetAll
{
	public sealed record GetAllQueryResponse(
			bool IsSucess,
			int results,
			IList<Category> data
		);
	
}

