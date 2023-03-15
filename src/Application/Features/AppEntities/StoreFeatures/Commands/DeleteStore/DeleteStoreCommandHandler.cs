using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.StoreFeatures.Commands.DeleteStore
{
    public class DeleteStoreCommandHandler : ICommandHandler<DeleteStoreCommand, DeleteStoreCommandResponse>
    {
        private readonly IStoreService _storeService;
        private readonly IProductStore _productStore;

        public DeleteStoreCommandHandler(IStoreService storeService, IProductStore productStore)
        {
            _storeService = storeService;
            _productStore = productStore;
        }
        public async Task<DeleteStoreCommandResponse> Handle(DeleteStoreCommand request, CancellationToken cancellationToken)
        {
            var productStores = await _productStore.GetProductStoresByStoreId(request.Id);

            if(productStores.Count()> 0)
            {
                return new("Bu mağaza bağlı ürünler var.Önce ürünler ile olan bağıını koparın");
            }
            await _storeService.Delete(request.Id, cancellationToken);
            return new();
        }
    }
}

