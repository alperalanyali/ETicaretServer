using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.PaymentTypeFeatures.Commands.CreatePaymentType
{
    public class CreatePaymentTypeCommandHandler : ICommandHandler<CreatePaymentTypeCommand, CreatePaymentTypeCommandResponse>
    {
        private readonly IPaymentTypeService _paymentTypeService;
        public CreatePaymentTypeCommandHandler(IPaymentTypeService paymentTypeService)
        {
            _paymentTypeService = paymentTypeService;
        }
        public async Task<CreatePaymentTypeCommandResponse> Handle(CreatePaymentTypeCommand request, CancellationToken cancellationToken)
        {
            var paymentType = new PaymentType(request.Code,request.Name);
            await _paymentTypeService.Create(paymentType, cancellationToken);
            return new();
        }
    }
}

