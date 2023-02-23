using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.OrderFeatures.Commands.UpdateOrder
{
    public class UpdateOrderCommandHandler : ICommandHandler<UpdateOrderCommand, UpdateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        public UpdateOrderCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _orderService.GetById(request.Id);
            order.AddressId = request.AddressId;
            order.BasketId = request.BasketId;
            order.PaymentTypeId = request.PaymentId;

            await _orderService.Update(order, cancellationToken);
            return new();
        }
    }
}

