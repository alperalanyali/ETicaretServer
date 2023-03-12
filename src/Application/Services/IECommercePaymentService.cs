using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IECommercePaymentService
	{
        Task UpdateAsync(ECommercePayment eCommercePayment, CancellationToken cancellationToken);
        Task<ECommercePayment> GetFirstAsync();
    }
}

