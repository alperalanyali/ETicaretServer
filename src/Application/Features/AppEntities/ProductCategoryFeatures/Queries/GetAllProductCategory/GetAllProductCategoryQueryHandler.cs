using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Queries.GetAllProductCategory
{
    public class GetAllProductCategoryQueryHandler : IQueryHandler<GetAllProductCategoryQuery, GetAllProductCategoryQueryResponse>
    {
        private readonly IProductCategoryService _productCatService;

        public GetAllProductCategoryQueryHandler(IProductCategoryService productCatService)
        {
            _productCatService = productCatService;
        }

        public async Task<GetAllProductCategoryQueryResponse> Handle(GetAllProductCategoryQuery request, CancellationToken cancellationToken)
        {
            var productCategories = await _productCatService.GetAllProductCategory(request.PageNumber,request.PageSize);

            return new(productCategories.Count(), productCategories);
        }
    }
}

