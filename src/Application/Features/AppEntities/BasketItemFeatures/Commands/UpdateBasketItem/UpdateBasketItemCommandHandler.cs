using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.BasketItemFeatures.Commands.UpdateBasketItem
{
    public class UpdateBasketItemCommandHandler : ICommandHandler<UpdateBasketItemCommand, UpdateBasketItemCommandResponse>
    {

        private readonly IBasketItemService _basketItemService;

        public UpdateBasketItemCommandHandler(IBasketItemService basketItemService)
        {
            _basketItemService = basketItemService;
        }

        public async Task<UpdateBasketItemCommandResponse> Handle(UpdateBasketItemCommand request, CancellationToken cancellationToken)
        {
            var basketItem =await _basketItemService.GetById(request.Id);
            basketItem.ProductId = request.ProductId;
            basketItem.Quantity = request.Quantity;
            basketItem.TotalPrice = request.TotalPrice;
            basketItem.BasketId = request.BasketId;
            basketItem.Quantity = request.Quantity;

            await _basketItemService.Update(basketItem, cancellationToken);

            return new();

        }
    }
}

