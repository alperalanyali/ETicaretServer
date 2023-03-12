﻿using System;
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
            basketItem.ProductStoreId = request.ProductStoreId;
            basketItem.Quantity = request.Quantity;
            basketItem.TotalPrice = request.TotalPrice;
            basketItem.BasketId = request.BasketId;
            

            await _basketItemService.Update(basketItem, cancellationToken);

            return new();

        }
    }
}

