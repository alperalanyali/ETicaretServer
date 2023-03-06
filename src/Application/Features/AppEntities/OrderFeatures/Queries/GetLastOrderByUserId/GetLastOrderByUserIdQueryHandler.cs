using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.OrderFeatures.Queries.GetLastOrderByUserId
{
    public class GetLastOrderByUserIdQueryHandler : IQueryHandler<GetLastOrderByUserIdQuery, GetLastOrderByUserIdQueryResponse>
    {
        private readonly IOrderService _orderService;

        public GetLastOrderByUserIdQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<GetLastOrderByUserIdQueryResponse> Handle(GetLastOrderByUserIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _orderService.GetLastOrderByUserId(request.UserId);

            return new(result);
        }
    }
}

