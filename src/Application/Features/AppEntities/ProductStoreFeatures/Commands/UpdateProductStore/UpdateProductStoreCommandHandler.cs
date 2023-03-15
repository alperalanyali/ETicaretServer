using System;
using Application.Helpers;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductStoreFeatures.Commands.UpdateProductStore
{
    public class UpdateProductStoreCommandHandler : ICommandHandler<UpdateProductStoreCommand, UpdateProductStoreCommandResponse>
    {
        private readonly IProductStore _productStoreService;
        public UpdateProductStoreCommandHandler(IProductStore productStore)
        {
            _productStoreService = productStore;
        }
        public async Task<UpdateProductStoreCommandResponse> Handle(UpdateProductStoreCommand request, CancellationToken cancellationToken)
        {
            string filePath = "/Users/alperalanyali/Desktop/ETicaret/ETicaretClient/src/assets/images/";
            var stringFileName = FileService.FileSaveToServer(request.ImageUrl, filePath);
            var imageUrl = $"{stringFileName}";
            var productStore = await _productStoreService.GetById(request.Id);
            //productStore.ProductId = new Guid(request.ProductId);
            productStore.Code = request.Code;
            productStore.Name = request.Name;
            productStore.Description = request.Description;
            productStore.QuantityTypeId = new Guid(request.QuantityTypeId);
            productStore.ImageUrl = imageUrl;
            productStore.Price = request.Price;
            productStore.InStock = request.InStock;
            productStore.StoreId = new Guid(request.StoreId);
            productStore.Price = request.Price;            
            await _productStoreService.UpdateAsync(productStore, cancellationToken);

            return new();
        }
    }
}

