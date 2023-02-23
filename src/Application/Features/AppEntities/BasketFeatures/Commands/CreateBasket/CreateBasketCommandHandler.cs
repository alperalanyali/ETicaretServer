using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.BasketFeatures.Commands.CreateBasket
{
	public class CreateBasketCommandHandler:ICommandHandler<CreateBasketCommand,CreateBasketCommandResponse>
	{
        private readonly IBasketService _basketService;

        public CreateBasketCommandHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task<CreateBasketCommandResponse> Handle(CreateBasketCommand request, CancellationToken cancellationToken)
        {
            var basket = new Basket(userId: request.UserId, totalAmount: request.TotalAmount);

           await _basketService.CreateBasket(basket, cancellationToken);
            var response = new CreateBasketCommandResponse("Basket başarılı şekilde olusturuldu.");

            return response;
        }
    }
}

