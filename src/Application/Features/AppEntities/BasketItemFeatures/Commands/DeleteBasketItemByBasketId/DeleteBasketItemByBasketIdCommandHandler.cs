using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.BasketItemFeatures.Commands.DeleteBasketItemByBasketId
{
    public class DeleteBasketItemByBasketIdCommandHandler : ICommandHandler<DeleteBasketItemByBasketIdCommand, DeleteBasketItemByBasketIdCommandResponse>
    {
        private readonly IBasketItemService _basketItemService;

        public DeleteBasketItemByBasketIdCommandHandler(IBasketItemService basketItemService)
        {
            _basketItemService = basketItemService;
        }

        public async Task<DeleteBasketItemByBasketIdCommandResponse> Handle(DeleteBasketItemByBasketIdCommand request, CancellationToken cancellationToken)
        {
            var basketItems = await _basketItemService.GetBasketItemByBasketId(request.BasketId);
            _basketItemService.DeleteBasketItemByBasketId(basketItems, cancellationToken);
            return new("Sepetteki ürünler silindi");
        }
    }
}

