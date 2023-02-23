using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IAddresesService
	{
		Task Create(Address addreses, CancellationToken cancellationToken);
		Task Update(Address address, CancellationToken cancellationToken);
		Task Delete(string id, CancellationToken cancellationToken);
		Task<IList<Address>> GetAllAddreses();
		Task<Address> GetById(string id);
		Task<IList<Address>> GetAddresesByUserId(string userId);
	}
}

