using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IPaymentTypeService
	{

		Task Create(PaymentType paymentType, CancellationToken cancellationToken);
		Task Update(PaymentType paymentType, CancellationToken cancellationToken);
		Task Delete(string id, CancellationToken cancellationToken);
		Task<IList<PaymentType>> GetAll();
		Task<PaymentType> GetById(string id);
	}
}

