using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.OrderItemFeatures.Commands.CreateOrderItems
{
    public class CreateOrderItemsCommandHandler : ICommandHandler<CreateOrderItemsCommand, CreateOrderItemsCommandResponse>
    {
        private readonly IOrderItemService _orderItemService;

        public CreateOrderItemsCommandHandler(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }
        public async Task<CreateOrderItemsCommandResponse> Handle(CreateOrderItemsCommand request, CancellationToken cancellationToken)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            //orderItems = (List<OrderItem>)request.BasketItems.Select(p => new OrderItem(request.OrderId,p.ProductId,p.Quantity,p.TotalPrice));

            foreach (var basketItem in request.BasketItems)
            {
                var orderItem = new OrderItem(request.OrderId, basketItem.ProductId, basketItem.Quantity, basketItem.TotalPrice);
                orderItems.Add(orderItem);
            }

            await _orderItemService.AddRange(orderItems, cancellationToken);

            return new("Sepetteki ürünler siparişe başarılu şekilde aktarıldı");
            
        }
    }
}

