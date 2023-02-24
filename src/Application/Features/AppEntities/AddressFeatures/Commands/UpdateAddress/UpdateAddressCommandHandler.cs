using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.AddressFeatures.Commands.UpdateAddress
{
    public class UpdateAddressCommandHandler : ICommandHandler<UpdateAddressCommand, UpdateAddressCommandResponse>
    {
        private IAddresesService _addressesService;
        public UpdateAddressCommandHandler(IAddresesService addresesService)
        {
            _addressesService = addresesService;
        }
        public async Task<UpdateAddressCommandResponse> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            var address = await _addressesService.GetById(request.Id);
            address.City = request.City;
            address.Country = request.Country;
            address.Address1 = request.Address1;
            address.Address2 = request.Address2;

            await _addressesService.Update(address, cancellationToken);

            return new();
        }
    }
}

