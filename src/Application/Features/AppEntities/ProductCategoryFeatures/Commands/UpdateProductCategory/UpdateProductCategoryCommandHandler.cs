using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Commands.UpdateProductCategory
{
    public class UpdateProductCategoryCommandHandler : ICommandHandler<UpdateProductCategoryCommand, UpdateProductCategoryCommandResponse>
    {

        private readonly IProductCategoryService _productCatService;

        public UpdateProductCategoryCommandHandler(IProductCategoryService productCatService)
        {
            _productCatService = productCatService;
        }

        public async Task<UpdateProductCategoryCommandResponse> Handle(UpdateProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var productCategory = await _productCatService.GetById(request.Id);
            productCategory.ProductStoreId = request.ProductId;
            productCategory.CategoryId = request.CategoryId;

            await _productCatService.UpdateProductCategory(productCategory, cancellationToken);

            return new();
        }
    }
}

