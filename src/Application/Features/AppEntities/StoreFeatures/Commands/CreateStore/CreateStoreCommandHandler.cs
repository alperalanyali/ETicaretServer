using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.StoreFeatures.Commands.CreateStore
{
    public class CreateStoreCommandHandler : ICommandHandler<CreateStoreCommand, CreateStoreCommandResponse>
    {
        private readonly IStoreService _storeService;

        public CreateStoreCommandHandler(IStoreService storeService)
        {
            _storeService = storeService;
        }

        public async Task<CreateStoreCommandResponse> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            var newStore = new Store(request.StoreName,request.Address);
            await _storeService.CreateAsync(newStore, cancellationToken);

            return new();
        }
    }
}

