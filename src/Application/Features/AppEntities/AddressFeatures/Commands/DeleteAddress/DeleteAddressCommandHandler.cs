using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.AddressFeatures.Commands.DeleteAddress
{
    public class DeleteAddressCommandHandler : ICommandHandler<DeleteAddressCommand, DeleteAddressCommandResponse>
    {
        private readonly IAddresesService _addressService;
        public DeleteAddressCommandHandler(IAddresesService addresesService)
        {
            _addressService = addresesService;
        }
        public async Task<DeleteAddressCommandResponse> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            await _addressService.Delete(request.Id, cancellationToken);
            return new();
        }
    }
}

