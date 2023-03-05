using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IQueryHandler<GetProductByIdQuery, GetProductByIdQueryResponse>
    {
        private readonly IProductService _productService;

        public GetProductByIdQueryHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<GetProductByIdQueryResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _productService.GetById(request.Id);

            return new(result);
        }
    }
}

