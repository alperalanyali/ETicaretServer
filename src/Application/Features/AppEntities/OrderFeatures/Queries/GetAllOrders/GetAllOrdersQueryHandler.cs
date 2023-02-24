using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.OrderFeatures.Queries.GetAllOrders
{
    public class GetAllOrdersQueryHandler : IQueryHandler<GetAllOrdersQuery, GetAllOrdersQueryResponse>
    {
        private readonly IOrderService _orderService;

        public GetAllOrdersQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<GetAllOrdersQueryResponse> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = await _orderService.GetAllOrders();

            return new(true, orders.Count(), orders);
        }
    }

}

