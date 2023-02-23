using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.OrderItemFeatures.Commands.DeleteOrderItem
{
    public class DeleteOrderItemCommandHandler : ICommandHandler<DeleteOrderItemCommand, DeleteOrderItemCommandResponse>
    {
        private readonly IOrderItemService _orderItemService;

        public DeleteOrderItemCommandHandler(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        public async Task<DeleteOrderItemCommandResponse> Handle(DeleteOrderItemCommand request, CancellationToken cancellationToken)
        {
            await _orderItemService.Delete(request.Id, cancellationToken);
            return new();
        }
    }
}

