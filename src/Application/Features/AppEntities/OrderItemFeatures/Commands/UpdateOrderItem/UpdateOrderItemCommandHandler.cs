using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.OrderItemFeatures.Commands.UpdateOrderItem
{
    public class UpdateOrderItemCommandHandler : ICommandHandler<UpdateOrderItemCommand, UpdateOrderItemCommandResponse>
    {
        private readonly IOrderItemService _orderItemService;

        public UpdateOrderItemCommandHandler(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        public async Task<UpdateOrderItemCommandResponse> Handle(UpdateOrderItemCommand request, CancellationToken cancellationToken)
        {
            var orderItem = await _orderItemService.GetById(request.Id);
            orderItem.ProductStoreId = request.ProductStoreId;
            orderItem.Quantity = request.Quantity;
            orderItem.TotalPrice = request.TotalPrice;
            orderItem.OrderId = request.OrderId;

            await _orderItemService.Update(orderItem, cancellationToken);

            return new();
        }
    }
}

