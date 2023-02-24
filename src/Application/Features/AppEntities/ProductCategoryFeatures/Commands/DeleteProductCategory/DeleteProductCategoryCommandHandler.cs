using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductCategoryFeatures.Commands.DeleteProductCategory
{
    public class DeleteProductCategoryCommandHandler : ICommandHandler<DeleteProductCategoryCommand, DeleteProductCategoryCommandResponse>
    {
        private readonly IProductCategoryService _productCatService;

        public DeleteProductCategoryCommandHandler(IProductCategoryService productCatService)
        {
            _productCatService = productCatService;
        }

        public async Task<DeleteProductCategoryCommandResponse> Handle(DeleteProductCategoryCommand request, CancellationToken cancellationToken)
        {
            await _productCatService.DeleteProductCategory(request.Id, cancellationToken);
            return new();
        }
    }
}

