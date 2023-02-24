using System;
using Application.Messaging;

namespace Application.Features.AppEntities.BasketItemFeatures.Queries.GetById
{
	public sealed record GetByIdQuery(string Id):IQuery<GetByIdQueryResponse>;
	
}

