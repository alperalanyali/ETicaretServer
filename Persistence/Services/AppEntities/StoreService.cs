using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.StoreRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
    public class StoreService : IStoreService
    {
        private readonly IStoreCommandRepository _storeCommand;
        private readonly IStoreQueryRepository _storeQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public StoreService(IStoreCommandRepository storeCommandRepository, IStoreQueryRepository storeQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _storeCommand = storeCommandRepository;
            _storeQuery = storeQueryRepository;
            _unitOfWork = appUnitOfWork;
        }

        public async Task CreateAsync(Store store, CancellationToken cancellationToken)
        {
            await _storeCommand.AddAsync(store, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(string id, CancellationToken cancellationToken)
        {
            _storeCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<Store>> GetAll()
        {
            var results = await _storeQuery.GetAll().ToListAsync();

            return results;
        }

        public async Task<Store> GetById(string id)
        {
            var result = await _storeQuery.GetById(id);

            return result;
        }

        public async Task UpdateAsync(Store store, CancellationToken cancellationToken)
        {
            _storeCommand.Update(store);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

