using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.BasketFeatures.Queries.GetBasketIdByUserId
{
    public class GetBasketIdByUserIdQueryHandler : IQueryHandler<GetBasketIdByUserIdQuery, GetBasketIdByUserIdQueryResponse>
    {
        private readonly IBasketService _basketService;
        public GetBasketIdByUserIdQueryHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }
        public async Task<GetBasketIdByUserIdQueryResponse> Handle(GetBasketIdByUserIdQuery request, CancellationToken cancellationToken)
        {
            var basket = await _basketService.GetBasketIdByUserId(request.UserId);
            decimal amount = 0;
            foreach (var basketItem in basket.BasketItems)
            {
                amount += basketItem.TotalPrice;
            }
            basket.TotalAmount = amount;
            return new(true,1,basket);
        }
    }


}

