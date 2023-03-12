using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.ECommercePayments;
using Domain.UnitOfWork;

namespace Persistence.Services.AppEntities
{
    public class ECommercePaymentService : IECommercePaymentService
    {
        private readonly IECommercePaymentsCommandRepository _command;
        private readonly IECommercePaymentsQueryRepository _query;
        private readonly IAppUnitOfWork _unitOfWork;
        public ECommercePaymentService(IECommercePaymentsCommandRepository eCommercePaymentsCommandRepository, IECommercePaymentsQueryRepository commercePaymentsQueryRepository, IAppUnitOfWork appUnitOfWork) 
        {
            _command = eCommercePaymentsCommandRepository;
            _query = commercePaymentsQueryRepository;
            _unitOfWork = appUnitOfWork;
        }
        public async Task<ECommercePayment> GetFirstAsync()
        {
            var payment = await _query.GetFirst();
            return payment;
        }

        public async Task UpdateAsync(ECommercePayment eCommercePayment, CancellationToken cancellationToken)
        {
            _command.Update(eCommercePayment);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

