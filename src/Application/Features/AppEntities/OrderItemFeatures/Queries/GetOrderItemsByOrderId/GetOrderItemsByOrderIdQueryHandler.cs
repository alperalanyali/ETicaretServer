using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.OrderItemFeatures.Queries.GetOrderItemsByOrderId
{
    public class GetOrderItemsByOrderIdQueryHandler : IQueryHandler<GetOrderItemsByOrderIdQuery, GetOrderItemsByOrderIdQueryResponse>
    {
        private readonly IOrderItemService _orderItemService;

        public GetOrderItemsByOrderIdQueryHandler(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        public async Task<GetOrderItemsByOrderIdQueryResponse> Handle(GetOrderItemsByOrderIdQuery request, CancellationToken cancellationToken)
        {
            var orderITems = await _orderItemService.GetOrderItemByOrderId(request.orderId);

            return new(true, orderITems.Count(), orderITems);
        }
    }
}

