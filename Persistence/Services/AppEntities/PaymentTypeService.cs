using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.PaymentTypeRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
    public class PaymentTypeService : IPaymentTypeService
    {
        private readonly IPaymentTypeCommandRepository _paymentTypeCommand;
        private readonly IPaymentTypeQueryRepository _paymentTypeQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public PaymentTypeService(IPaymentTypeCommandRepository paymentTypeCommandRepository, IPaymentTypeQueryRepository paymentTypeQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _paymentTypeCommand = paymentTypeCommandRepository;
            _paymentTypeQuery = paymentTypeQueryRepository;
            _unitOfWork = appUnitOfWork;
        }

        public async Task Create(PaymentType paymentType, CancellationToken cancellationToken)
        {
            await _paymentTypeCommand.AddAsync(paymentType, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(string id, CancellationToken cancellationToken)
        {
            await _paymentTypeCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<PaymentType>> GetAll()
        {
            return await _paymentTypeQuery.GetAll().ToListAsync();
        }

        public async Task<PaymentType> GetById(string id)
        {
            return await _paymentTypeQuery.GetById(id, false);
        }

        public async Task Update(PaymentType paymentType, CancellationToken cancellationToken)
        {
            _paymentTypeCommand.Update(paymentType);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

