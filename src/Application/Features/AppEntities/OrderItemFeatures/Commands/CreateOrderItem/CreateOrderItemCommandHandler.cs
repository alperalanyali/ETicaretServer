using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.OrderItemFeatures.Commands.CreateOrderItem
{
	public class CreateOrderItemCommandHandler:ICommandHandler<CreateOrderItemCommand,CreateOrderItemCommandResponse>
	{
        private readonly IOrderItemService _orderItemService;

        public CreateOrderItemCommandHandler(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        public async Task<CreateOrderItemCommandResponse> Handle(CreateOrderItemCommand request, CancellationToken cancellationToken)
        {
            var orderItem = new OrderItem(request.OrderId, request.ProductId, request.Quantity, request.TotalPrice);
            await _orderItemService.Create(orderItem, cancellationToken);

            return new();
        }
    }
}

