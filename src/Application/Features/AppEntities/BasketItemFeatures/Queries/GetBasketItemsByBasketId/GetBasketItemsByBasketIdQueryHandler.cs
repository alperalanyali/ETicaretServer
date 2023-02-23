using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.BasketItemFeatures.Queries.GetBasketItemsByBasketId
{
    public class GetBasketItemsByBasketIdQueryHandler : IQueryHandler<GetBasketItemsByBasketIdQuery, GetBasketItemsByBasketIdQueryResponse>
    {
        private readonly IBasketItemService _basketItemService;
        public GetBasketItemsByBasketIdQueryHandler(IBasketItemService basketItemService)
        {
            _basketItemService = basketItemService;
        }
        public async Task<GetBasketItemsByBasketIdQueryResponse> Handle(GetBasketItemsByBasketIdQuery request, CancellationToken cancellationToken)
        {
            var basketItems = await _basketItemService.GetBasketItemByBasketId(request.BasketId.ToString());
            return new(true, basketItems.Count(), basketItems);
        }
    }
}

