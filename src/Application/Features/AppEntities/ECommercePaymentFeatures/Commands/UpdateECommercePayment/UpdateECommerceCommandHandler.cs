using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ECommercePaymentFeatures.Commands.UpdateECommercePayment
{
	public class UpdateECommerceCommandHandler:ICommandHandler<UpdateECommercePaymentCommand,UpdateECommercePaymentCommandResponse>
	{
        private readonly IECommercePaymentService _service;

        public UpdateECommerceCommandHandler(IECommercePaymentService eCommercePaymentService)
		{
            _service = eCommercePaymentService;

        }

        public async Task<UpdateECommercePaymentCommandResponse> Handle(UpdateECommercePaymentCommand request, CancellationToken cancellationToken)
        {
            var payment = await _service.GetFirstAsync();
            payment.Name = request.Name;
            payment.Surname = request.Surname;
            payment.GsmNumber = request.GsmNumber;
            payment.City = request.City;
            payment.Country = request.Country;
            payment.Email = request.Email;
            payment.ZipCode = request.ZipCode;
            payment.RegistrationAddress = request.RegistrationAddress;
            payment.IdentityNumber = request.IdentityNumber;
            payment.UserId = request.UserId;

            await _service.UpdateAsync(payment, cancellationToken);
            return new();
        }
    }
}

