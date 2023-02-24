using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.PaymentTypeFeatures.Queries.GetPaymentTypeById
{
    public class GetPaymentTypeByIdQueryHandler : IQueryHandler<GetPaymentTypeByIdQuery, GetPaymentTypeByIdQueryResponse>
    {
        private readonly IPaymentTypeService _paymentTypeService;

        public GetPaymentTypeByIdQueryHandler(IPaymentTypeService paymentTypeService)
        {
            _paymentTypeService = paymentTypeService;
        }

        public async Task<GetPaymentTypeByIdQueryResponse> Handle(GetPaymentTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var payment = await _paymentTypeService.GetById(request.Id);
            return new(payment);
        }
    }
}

