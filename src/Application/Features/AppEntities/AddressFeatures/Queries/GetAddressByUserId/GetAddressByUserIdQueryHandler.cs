using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.AddressFeatures.Queries.GetAddressByUserId
{
    public class GetAddressByUserIdQueryHandler : IQueryHandler<GetAddressByUserIdQuery, GetAddressByUserIdQueryResponse>
    {
        private readonly IAddresesService _addressService;

        public GetAddressByUserIdQueryHandler(IAddresesService addressService)
        {
            _addressService = addressService;
        }

        public async Task<GetAddressByUserIdQueryResponse> Handle(GetAddressByUserIdQuery request, CancellationToken cancellationToken)
        {
            var addresses = await _addressService.GetAddresesByUserId(request.UserId);
            return new(addresses.Count(), addresses);
        }
    }
}

