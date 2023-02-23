﻿using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.BasketRepository
{
	public interface IBasketCommandRepository: IAppCommandRepository<Basket>
	{
	}
}

