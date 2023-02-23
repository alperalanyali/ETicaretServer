using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.BasketFeatures.Commands.DeleteBasket
{
	public class DeleteBasketCommandHandler:ICommandHandler<DeleteBasketCommand,DeleteBasketCommandResponse>
	{
        private readonly IBasketService _basketService;

        public DeleteBasketCommandHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task<DeleteBasketCommandResponse> Handle(DeleteBasketCommand request, CancellationToken cancellationToken)
        {
            await _basketService.Delete(request.Id, cancellationToken);

            return new();
        }
    }
}

