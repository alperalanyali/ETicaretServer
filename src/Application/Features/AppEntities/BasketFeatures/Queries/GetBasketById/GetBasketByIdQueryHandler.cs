using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.BasketFeatures.Queries.GetBasketById
{
	public class GetBasketByIdQueryHandler:IQueryHandler<GetBasketByIdQuery,GetBasketByIdQueryResponse>
	{
        private readonly IBasketService _basketService;
        public GetBasketByIdQueryHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task<GetBasketByIdQueryResponse> Handle(GetBasketByIdQuery request, CancellationToken cancellationToken)
        {
            var basket = await _basketService.GetById(request.BasketId);

            return new(true, 1, basket);
        }
    }
}

