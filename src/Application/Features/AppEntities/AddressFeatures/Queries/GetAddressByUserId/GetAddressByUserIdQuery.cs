using System;
using Application.Messaging;

namespace Application.Features.AppEntities.AddressFeatures.Queries.GetAddressByUserId
{
	public sealed record GetAddressByUserIdQuery(
		string UserId
		):IQuery<GetAddressByUserIdQueryResponse> ;

}

