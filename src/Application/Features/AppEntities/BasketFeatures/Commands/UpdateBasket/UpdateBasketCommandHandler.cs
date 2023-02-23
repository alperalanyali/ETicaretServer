using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.BasketFeatures.Commands.UpdateBasket
{
	public class UpdateBasketCommandHandler:ICommandHandler<UpdateBasketCommand,UpdateBasketCommandResponse>
	{
        private readonly IBasketService _basketService;

        public UpdateBasketCommandHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task<UpdateBasketCommandResponse> Handle(UpdateBasketCommand request, CancellationToken cancellationToken)
        {
            var basket = await _basketService.GetById(request.Id);
            basket.TotalAmount = request.TotalAmount;
            basket.UserId = request.UserId;
            await _basketService.Update(basket, cancellationToken);

            var response = new UpdateBasketCommandResponse("Kayit basarili sekilde guncllendi.");

            return response;
        }
    }
	
}

