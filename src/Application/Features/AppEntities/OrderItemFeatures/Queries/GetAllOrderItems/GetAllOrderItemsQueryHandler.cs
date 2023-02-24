using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.OrderItemFeatures.Queries.GetAllOrderItems
{
    public class GetAllOrderItemsQueryHandler : IQueryHandler<GetAllOrderItemsQuery, GetAllOrderItemsQueryResponse>
    {
        private readonly IOrderItemService _orderItemService;

        public GetAllOrderItemsQueryHandler(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        public async Task<GetAllOrderItemsQueryResponse> Handle(GetAllOrderItemsQuery request, CancellationToken cancellationToken)
        {
            var orderItems = await _orderItemService.GetAllOrderItems();
            return new(orderItems.Count(), orderItems);
        }
    }
}

