using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IStoreService
	{
        Task<IList<Store>> GetAll();
        Task<Store> GetById(string id);
        Task CreateAsync(Store store, CancellationToken cancellationToken);
        Task UpdateAsync(Store store, CancellationToken cancellationToken);
        Task Delete(string id, CancellationToken cancellationToken);
    }
}

