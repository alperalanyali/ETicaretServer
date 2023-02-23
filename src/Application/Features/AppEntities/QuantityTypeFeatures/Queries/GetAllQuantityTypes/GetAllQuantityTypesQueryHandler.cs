using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.QuantityTypeFeatures.Queries.GetAllQuantityTypes
{
    public class GetAllQuantityTypesQueryHandler : IQueryHandler<GetAllQuantityTypesQuery, GetAllQuantityTypesQueryResponse>
    {
        private readonly IQuantityTypeService _quantityTypeService;

        public GetAllQuantityTypesQueryHandler(IQuantityTypeService quantityTypeService)
        {
            _quantityTypeService = quantityTypeService;
        }

        public async Task<GetAllQuantityTypesQueryResponse> Handle(GetAllQuantityTypesQuery request, CancellationToken cancellationToken)
        {
            var quantityTypes = await _quantityTypeService.GetAll();

            return new(quantityTypes.Count(), quantityTypes);
        }
    }
}

