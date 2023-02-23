using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IQueryHandler<GetAllProductsQuery, GetAllProductsQueryResponse>
    {
        private readonly IProductService _productService;

        public GetAllProductsQueryHandler(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<GetAllProductsQueryResponse> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productService.GetAllProduct();

            return new(true, products.Count(), products);
        }
    }
}

