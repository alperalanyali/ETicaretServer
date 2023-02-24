using System;
using Application.Messaging;

namespace Application.Features.AppEntities.PaymentTypeFeatures.Queries.GetPaymentTypeById
{
	public sealed record GetPaymentTypeByIdQuery(
		string Id
		):IQuery<GetPaymentTypeByIdQueryResponse>;
	
}

