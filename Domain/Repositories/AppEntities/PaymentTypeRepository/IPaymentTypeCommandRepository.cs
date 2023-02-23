using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.PaymentTypeRepository
{
	public interface IPaymentTypeCommandRepository:IAppCommandRepository<PaymentType>
	{
	}
}

