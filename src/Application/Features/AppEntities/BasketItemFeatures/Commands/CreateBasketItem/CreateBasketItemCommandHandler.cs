using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.BasketItemFeatures.Commands.CreateBasketItem
{
    public class CreateBasketItemCommandHandler : ICommandHandler<CreateBasketItemCommand, CreateBasketItemCommandResponse>
    {
        private readonly IBasketItemService _basketItemService;
        public CreateBasketItemCommandHandler(IBasketItemService basketItemService)
        {
            _basketItemService = basketItemService;
        }
        public async Task<CreateBasketItemCommandResponse> Handle(CreateBasketItemCommand request, CancellationToken cancellationToken)
        {
            var basketItem = new BasketItem(request.BasketId, request.ProductId, request.Quantity, request.TotalPrice);
            await _basketItemService.Create(basketItem, cancellationToken);

            return new();
        }
    }
}

