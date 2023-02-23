using System;
using Domain.Entities;

namespace Application.Features.AppEntities.PaymentTypeFeatures.Queries.GetAllPaymentType
{
	public sealed record GetAllPaymentTypeQueryResponse(
		int results,
		IList<PaymentType> Data
		);
	
}

