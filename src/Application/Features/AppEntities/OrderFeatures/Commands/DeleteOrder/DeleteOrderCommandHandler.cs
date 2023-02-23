using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.OrderFeatures.Commands.DeleteOrder
{
    public class DeleteOrderCommandHandler : ICommandHandler<DeleteOrderCommand, DeleteOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        public DeleteOrderCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<DeleteOrderCommandResponse> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            await _orderService.Delete(request.Id, cancellationToken);
            return new();
        }
    }
}

