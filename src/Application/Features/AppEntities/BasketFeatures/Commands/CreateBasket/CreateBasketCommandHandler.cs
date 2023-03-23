using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.BasketFeatures.Commands.CreateBasket
{
	public class CreateBasketCommandHandler:ICommandHandler<CreateBasketCommand,CreateBasketCommandResponse>
	{
        private readonly IBasketService _basketService;
        private readonly IBasketItemService _basketItemService;
        private readonly IProductStore _productStore;
        public CreateBasketCommandHandler(IBasketService basketService, IBasketItemService basketItemService,IProductStore productStore)
        {
            _basketService = basketService;
            _basketItemService = basketItemService;
            _productStore = productStore;
        }

        public async Task<CreateBasketCommandResponse> Handle(CreateBasketCommand request, CancellationToken cancellationToken)
        {
            var basketControl = await _basketService.GetBasketIdByUserId(request.UserId.ToString());
            var response = new CreateBasketCommandResponse();
            if (basketControl == null)
            {
                var basket = new Basket(userId: request.UserId, totalAmount: request.TotalAmount);

                await _basketService.CreateBasket(basket, cancellationToken);

                var basketItem = new BasketItem(basket.Id, request.ProductStoreId, request.Quantity, request.TotalPrice);
                await _basketItemService.Create(basketItem, cancellationToken);
                response = new CreateBasketCommandResponse(1,"Basket başarılı şekilde olusturuldu.");
            }else
            {
                bool isExists = false;
                decimal quantity = 0;
                string basketItemId = "";
                
                foreach (var basketItem in basketControl.BasketItems)
                {
                    if(basketItem.ProductStoreId == request.ProductStoreId)
                    {
                        isExists = true;
                        quantity = basketItem.Quantity + 1;
                        basketItemId = basketItem.Id.ToString();

                        var productStore = await _productStore.GetById(request.ProductStoreId.ToString());
                        var totalPrice = productStore.Price * quantity;
                        var basketItemUpdate = await _basketItemService.GetById(basketItemId, true);
                        basketItemUpdate.Quantity = quantity;
                        basketItemUpdate.TotalPrice = totalPrice;
                        await _basketItemService.Update(basketItemUpdate, cancellationToken);
                        response = new CreateBasketCommandResponse(basketControl.BasketItems.Count, "Ürün güncellendi");
                    }              
                }

                var basketCount = await _basketService.GetBasketIdByUserId(request.UserId.ToString());
                if (!isExists)
                {
                    var basketItemInsert = new BasketItem(basketControl.Id, request.ProductStoreId, request.Quantity, request.TotalPrice);
                    await _basketItemService.Create(basketItemInsert, cancellationToken);
                    response = new CreateBasketCommandResponse(basketControl.BasketItems.Count,"Ürün başarılı şekilde eklendi");
                }
              

            }
           

            return response;
        }
    }
}

