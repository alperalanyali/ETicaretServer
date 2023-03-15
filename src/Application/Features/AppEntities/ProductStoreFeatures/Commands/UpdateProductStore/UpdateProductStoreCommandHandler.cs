using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductStoreFeatures.Commands.UpdateProductStore
{
    public class UpdateProductStoreCommandHandler : ICommandHandler<UpdateProductStoreCommand, UpdateProductStoreCommandResponse>
    {
        private readonly IProductStore _productStoreService;

        public async Task<UpdateProductStoreCommandResponse> Handle(UpdateProductStoreCommand request, CancellationToken cancellationToken)
        {
            var productStore = await _productStoreService.GetById(request.Id);
            //productStore.ProductId = new Guid(request.ProductId);
            productStore.StoreId = new Guid(request.StoreId);
            productStore.Price = request.Price;            
            await _productStoreService.UpdateAsync(productStore, cancellationToken);

            return new();
        }
    }
}

