using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.OrderItemRepository
{
	public interface IOrderItemCommandRepository:IAppCommandRepository<OrderItem>
	{
	}
}

