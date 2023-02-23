using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IQuantityTypeService
	{
        Task<IList<QuantityType>> GetAll();
        Task<QuantityType> GetById(string id);
        Task CreateAsync(QuantityType quantityType, CancellationToken cancellationToken);		
        Task UpdateAsync(QuantityType quantityType, CancellationToken cancellationToken);		
		Task Delete(string id, CancellationToken cancellationToken);
	}
}

