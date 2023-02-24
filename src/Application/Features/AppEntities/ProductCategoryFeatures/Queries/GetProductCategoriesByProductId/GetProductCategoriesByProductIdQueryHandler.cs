using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Queries.GetProductCategoriesByProductId
{
    public class GetProductCategoriesByProductIdQueryHandler : IQueryHandler<GetProductCategoriesByProductIdQuery, GetProductCategoriesByProductIdQueryResponse>
    {
        private readonly IProductCategoryService _productCatService;

        public GetProductCategoriesByProductIdQueryHandler(IProductCategoryService productCatService)
        {
            _productCatService = productCatService;
        }

        public async Task<GetProductCategoriesByProductIdQueryResponse> Handle(GetProductCategoriesByProductIdQuery request, CancellationToken cancellationToken)
        {
            var productCategories = await _productCatService.GetProductCategoryByProductId(request.ProductId);
            return new(productCategories.Count(), productCategories);
        }
    }
}

