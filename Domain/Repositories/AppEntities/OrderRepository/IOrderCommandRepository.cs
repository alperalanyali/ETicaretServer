﻿using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.OrderRepository
{
	public interface IOrderCommandRepository:IAppCommandRepository<Order>
	{
	}
}

