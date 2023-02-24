using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.BasketItemFeatures.Queries.GetById
{
    public class GetByIdQueryHandler : IQueryHandler<GetByIdQuery, GetByIdQueryResponse>
    {
        private readonly IBasketItemService _basketItemService;

        public GetByIdQueryHandler(IBasketItemService basketItemService)
        {
            _basketItemService = basketItemService;
        }

        public async Task<GetByIdQueryResponse> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var basketItem = await _basketItemService.GetById(request.Id);

            return new(basketItem);
        }
    }
}

