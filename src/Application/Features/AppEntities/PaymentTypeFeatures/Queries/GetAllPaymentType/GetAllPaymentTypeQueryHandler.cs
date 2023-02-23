using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.PaymentTypeFeatures.Queries.GetAllPaymentType
{
    public class GetAllPaymentTypeQueryHandler : IQueryHandler<GetAllPaymentTypeQuery, GetAllPaymentTypeQueryResponse>
    {
        private readonly IPaymentTypeService _paymentTypeService;

        public GetAllPaymentTypeQueryHandler(IPaymentTypeService paymentTypeService)
        {
            _paymentTypeService = paymentTypeService;
        }

        public async Task<GetAllPaymentTypeQueryResponse> Handle(GetAllPaymentTypeQuery request, CancellationToken cancellationToken)
        {
            var paymentTypes = await _paymentTypeService.GetAll();

            return new(paymentTypes.Count(), paymentTypes);
        }
    }
}

