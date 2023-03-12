using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.StoreFeatures.Commands.UpdateStore
{
	public class UpdateStoreCommandHandler:ICommandHandler<UpdateStoreCommand,UpdateStoreCommandResponse>
	{
        private readonly IStoreService _storeService;

        public UpdateStoreCommandHandler(IStoreService storeService)
        {
            _storeService = storeService;
        }

        public async Task<UpdateStoreCommandResponse> Handle(UpdateStoreCommand request, CancellationToken cancellationToken)
        {
            var store = await _storeService.GetById(request.store.Id.ToString());
            store.StoreName = request.store.StoreName;
            store.Address = request.store.Address;

            await _storeService.UpdateAsync(store, cancellationToken);

            return new();

        }
    }
}

