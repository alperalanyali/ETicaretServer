using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.AddressRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
    public class AddressService : IAddresesService
    {
        private readonly IAddressCommandRepository _addressCommand;
        private readonly IAddressQueryRepository _addressQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public AddressService(IAddressCommandRepository addressCommand, IAddressQueryRepository addressQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _addressCommand = addressCommand;
            _addressQuery = addressQueryRepository;
            _unitOfWork = appUnitOfWork;
        }

        public async Task Create(Address addreses, CancellationToken cancellationToken)
        {
            await _addressCommand.AddAsync(addreses, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(string id, CancellationToken cancellationToken)
        {
            await _addressCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<Address>> GetAddresesByUserId(string userId)
        {
            var results =await _addressQuery.GetWhere(p => p.UserId.ToString() == userId).ToListAsync();
            return results;
        }

        public async Task<IList<Address>> GetAllAddreses()
        {
            return await _addressQuery.GetAll().ToListAsync();
        }

        public async Task<Address> GetById(string id)
        {
            return await _addressQuery.GetById(id, false);
        }

        public async Task Update(Address address, CancellationToken cancellationToken)
        {
            _addressCommand.Update(address);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

