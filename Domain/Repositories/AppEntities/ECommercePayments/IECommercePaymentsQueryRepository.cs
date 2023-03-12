﻿using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.ECommercePayments
{
	public interface IECommercePaymentsQueryRepository: IAppQueryRepository<ECommercePayment>
    {
	}
}

