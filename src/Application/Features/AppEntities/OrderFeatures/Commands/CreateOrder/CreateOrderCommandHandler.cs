using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.OrderFeatures.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : ICommandHandler<CreateOrderCommand, CreateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;

        public CreateOrderCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order(request.UserId,request.Address,request.PaymentTypeId);
            await _orderService.Create(order, cancellationToken);
            return new();
        }
    }
}

