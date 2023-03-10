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
            store.Name = request.store.Name;
            store.Surname = request.store.Surname;
            store.GsmNumber = request.store.GsmNumber;
            store.RegistrationAddress = request.store.RegistrationAddress;
            store.Email = request.store.Email;
            store.IdentityNumber = request.store.IdentityNumber;
            store.City = request.store.City;
            store.Ip = request.store.Ip;
            store.ZipCode = request.store.ZipCode;
            store.UserId  = request.store.UserId;

            await _storeService.UpdateAsync(store, cancellationToken);

            return new();

        }
    }
}

