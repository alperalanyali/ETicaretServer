using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.BasketFeatures.Queries.GetBasketCountByUserId
{
    public class GetBasketCountByUserIdQueryHandler : IQueryHandler<GetBasketCountByUserIdQuery, GetBasketCountByUserIdQueryResponse>
    {
        private readonly IBasketService _basketService;
        private readonly IBasketItemService _basketItemService;
        public GetBasketCountByUserIdQueryHandler(IBasketService basketService, IBasketItemService basketItemService)
        {
            _basketService = basketService;
            _basketItemService = basketItemService;
        }

        public async Task<GetBasketCountByUserIdQueryResponse> Handle(GetBasketCountByUserIdQuery request, CancellationToken cancellationToken)
        {
            var basket = await _basketService.GetBasketIdByUserId(request.UserId);
       
            
            return new(basket.BasketItems.Count());
        }
    }
}

