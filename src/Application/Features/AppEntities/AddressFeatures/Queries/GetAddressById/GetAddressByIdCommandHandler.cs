using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.AddressFeatures.Queries.GetAddressById
{
    public class GetAddressByIdCommandHandler : ICommandHandler<GetAddressByIdCommand, GetAddressByIdCommandResponse>
    {
        private readonly IAddresesService _addressesService;

        public GetAddressByIdCommandHandler(IAddresesService addressesService)
        {
            _addressesService = addressesService;
        }

        public async Task<GetAddressByIdCommandResponse> Handle(GetAddressByIdCommand request, CancellationToken cancellationToken)
        {
            var address = await _addressesService.GetById(request.Id);

            return new(address);
        }
    }
}

