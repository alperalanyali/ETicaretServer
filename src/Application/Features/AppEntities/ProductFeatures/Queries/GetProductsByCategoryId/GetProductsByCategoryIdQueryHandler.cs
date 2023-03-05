using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetProductsByCategoryId
{
	public class GetProductsByCategoryIdQueryHandler:IQueryHandler<GetProductsByCategoryIdQuery,GetProductsByCategoryIdQueryResponse>
	{
        private readonly IProductService _productService;

        public GetProductsByCategoryIdQueryHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<GetProductsByCategoryIdQueryResponse> Handle(GetProductsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var products = await _productService.GetProductsByCategoryId(request.CategoryId);
            return new(true,products.Count(),products);
        }
    }
}

