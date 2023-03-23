using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.BasketItemFeatures.Commands.CreateBasketItem
{
    public class CreateBasketItemCommandHandler : ICommandHandler<CreateBasketItemCommand, CreateBasketItemCommandResponse>
    {
        private readonly IBasketItemService _basketItemService;
        private readonly IProductStore _productStore;
        public CreateBasketItemCommandHandler(IBasketItemService basketItemService,IProductStore productStore)
        {
            _basketItemService = basketItemService;
            _productStore = productStore;
        }
        public async Task<CreateBasketItemCommandResponse> Handle(CreateBasketItemCommand request, CancellationToken cancellationToken)
        {
            var basketItem = new BasketItem(request.BasketId, request.ProductStoreId, request.Quantity, request.TotalPrice);
            await _basketItemService.Create(basketItem, cancellationToken);

            var producStore = await _productStore.GetById(request.ProductStoreId.ToString());
            producStore.InStock = producStore.InStock - request.Quantity;
            await _productStore.UpdateAsync(producStore, cancellationToken);

            return new();
        }
    }
}

