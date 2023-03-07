using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.OrderFeatures.Queries.GetOrdersByUserId
{
	public class GetOrdersByUserIdQueryHandler:IQueryHandler<GetOrdersByUserIdQuery,GetOrdersByUserIdQueryResponse>
	{
        private readonly IOrderService _orderService;

        public GetOrdersByUserIdQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<GetOrdersByUserIdQueryResponse> Handle(GetOrdersByUserIdQuery request, CancellationToken cancellationToken)
        {
            var orders = await _orderService.GetOrdersByUserId(request.UserId);

            return new(true, orders.Count(), orders);
        }
    }
}

