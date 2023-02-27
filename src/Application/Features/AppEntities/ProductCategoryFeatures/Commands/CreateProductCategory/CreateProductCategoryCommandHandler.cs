using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Commands.CreateProductCategory
{
    public class CreateProductCategoryCommandHandler : ICommandHandler<CreateProductCategoryCommand, CreateProductCategoryCommandResponse>
    {
        private readonly IProductCategoryService _productCategorySer;
        public CreateProductCategoryCommandHandler(IProductCategoryService productCategoryService)
        {
            _productCategorySer = productCategoryService;
        }
        public async Task<CreateProductCategoryCommandResponse> Handle(CreateProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var productCategory = new ProductCategory(request.ProductId,request.CategoryId);
            await _productCategorySer.CreateProductCategory(productCategory, cancellationToken);
            return new();
        }
    }
}

