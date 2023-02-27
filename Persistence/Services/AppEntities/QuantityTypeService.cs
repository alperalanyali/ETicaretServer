using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.QuantityRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
    public class QuantityTypeService : IQuantityTypeService
    {
        private readonly IQuantityCommandRepository _quantityTypeCommand;
        private readonly IQuantityTypeQueryRepository _quantityTypeQuery;
        private readonly IAppUnitOfWork _unitOfWork;
        public QuantityTypeService(IQuantityCommandRepository quantityTypeCommand, IQuantityTypeQueryRepository quantityTypeQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _quantityTypeCommand = quantityTypeCommand;
            _quantityTypeQuery = quantityTypeQueryRepository;
            _unitOfWork = appUnitOfWork;
        }

        public async Task CreateAsync(QuantityType quantityType, CancellationToken cancellationToken)
        {
            await _quantityTypeCommand.AddAsync(quantityType, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

        }

        public async Task Delete(string id, CancellationToken cancellationToken)
        {
            await _quantityTypeCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<QuantityType>> GetAll()
        {
            var results = await _quantityTypeQuery.GetAll().ToListAsync();

            return results;
        }

        public async Task<QuantityType> GetById(string id)
        {
            var result = await _quantityTypeQuery.GetById(id, false);
            return result;
        }

        public async Task UpdateAsync(QuantityType quantityType, CancellationToken cancellationToken)
        {
            _quantityTypeCommand.Update(quantityType);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

