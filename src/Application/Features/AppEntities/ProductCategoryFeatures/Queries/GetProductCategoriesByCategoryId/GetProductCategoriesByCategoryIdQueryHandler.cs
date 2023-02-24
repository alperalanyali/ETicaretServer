using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Queries.GetProductCategoriesByCategoryId
{
    public class GetProductCategoriesByCategoryIdQueryHandler : IQueryHandler<GetProductCategoriesByCategoryIdQuery, GetProductCategoriesByCategoryIdQueryResponse>
    {
        private readonly IProductCategoryService _productCatService;

        public GetProductCategoriesByCategoryIdQueryHandler(IProductCategoryService productCatService)
        {
            _productCatService = productCatService;
        }

        public async Task<GetProductCategoriesByCategoryIdQueryResponse> Handle(GetProductCategoriesByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var productCategories = await _productCatService.GetProductCategoryByCategoryId(request.CategoryId);

            return new(productCategories.Count(), productCategories);
        }
    }
}

