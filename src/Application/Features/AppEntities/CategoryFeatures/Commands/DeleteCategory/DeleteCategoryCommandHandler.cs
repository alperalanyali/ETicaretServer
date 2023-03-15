using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.CategoryFeatures.Commands.DeleteCategory
{
    public class DeleteCategoryCommandHandler : ICommandHandler<DeleteCategoryCommand, DeleteCategoryCommandResponse>
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductStore _productStore;

        public DeleteCategoryCommandHandler(ICategoryService categoryService,IProductStore productStore)
        {
            _categoryService = categoryService;
            _productStore = productStore;
        }

        public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var productStores = await _productStore.GetProductStoresByCategoryId(request.Id);
            if (productStores.Count() > 0)
            {
                return new("Ürüne bağlı kategoriler silinemez. Önce ürün bağlantısını koparın!");
            }
            await _categoryService.Delete(request.Id, cancellationToken);
            return new();
        }
    }
}

