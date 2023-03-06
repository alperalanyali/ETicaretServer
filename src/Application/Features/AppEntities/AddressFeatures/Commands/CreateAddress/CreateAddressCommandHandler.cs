using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.AddressFeatures.Commands.CreateAddress
{
    public class CreateAddressCommandHandler : ICommandHandler<CreateAddressCommand, CreateAddressCommandResponse>
    {
        private readonly IAddresesService _addressService;
        public CreateAddressCommandHandler(IAddresesService addresesService)
        {
            _addressService = addresesService;
        }

        public async Task<CreateAddressCommandResponse> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var address = new Address(request.UserId,request.City,request.Country,request.Address1,request.Address2,request.ZipCode);
            await _addressService.Create(address, cancellationToken);
            return new();
        }
    }
}

