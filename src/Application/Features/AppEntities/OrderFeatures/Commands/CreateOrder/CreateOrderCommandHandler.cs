using System;
using Application.Messaging;
using Application.Services;
using Domain.Dtos;
using Domain.Entities;

namespace Application.Features.AppEntities.OrderFeatures.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : ICommandHandler<CreateOrderCommand, CreateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        private readonly IOrderItemService _orderItemService;
        private readonly IBasketService _basketService;
        private readonly IBasketItemService _basketItemService;
        private readonly IECommercePaymentService _ecommercePayment;

        private readonly IPaymentService _paymentService;

        public CreateOrderCommandHandler(IOrderService orderService,IOrderItemService orderItemService,IBasketService basketService,IBasketItemService basketItemService,IECommercePaymentService eCommercePaymentService,IPaymentService paymentService)
        {
            _orderService = orderService;
            _orderItemService = orderItemService;
            _basketService = basketService;
            _basketItemService = basketItemService;
            _ecommercePayment = eCommercePaymentService;
            _paymentService = paymentService;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order(request.UserId,request.Address,request.PaymentTypeId);
            await _orderService.Create(order, cancellationToken);

            var basketItems = await _basketItemService.GetBasketItemByBasketId(request.BasketId);

            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (var basketItem in basketItems)
            {
                var orderItem = new OrderItem(order.Id, basketItem.ProductStoreId, basketItem.Quantity, basketItem.TotalPrice);
                orderItems.Add(orderItem);

            }
            await _orderItemService.AddRange(orderItems, cancellationToken);

            await _basketService.Delete(request.BasketId, cancellationToken);
            var totalPrice = await _orderItemService.GetTotalPriceByOrderId(order.Id.ToString());

            var sellerInfo = await _ecommercePayment.GetFirstAsync();
            var paymentDto = new PaymentAddressDto(sellerInfo.Name, sellerInfo.Surname, sellerInfo.GsmNumber, sellerInfo.Email, sellerInfo.IdentityNumber, sellerInfo.Ip, sellerInfo.City, sellerInfo.Country, sellerInfo.ZipCode, sellerInfo.UserId, request.CardHolderName, request.CardNumber, request.ExpireMonth, request.ExpireYear, request.CVV,totalPrice, "asdfasdf", "adsfasfd",sellerInfo.RegistrationAddress);

            PaymentResult paymentResult = await _paymentService.PaymentWithIyzico(paymentDto);


            return new(paymentResult);
        }
    }
}

