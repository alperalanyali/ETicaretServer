﻿using System;
using Application.Messaging;
using Domain.Entities;
using Domain.Enums;

namespace Application.Features.AppEntities.OrderFeatures.Commands.CreateOrder
{
	public sealed record CreateOrderCommand(
		Guid Address,
		Guid PaymentTypeId,
		Guid UserId,
        string CardHolderName,
        string CardNumber,		
		string CVV,
		string ExpireMonth,
		string ExpireYear,
		string BasketId,
		OrderStatus Status = OrderStatus.Created
        ) :ICommand<CreateOrderCommandResponse>;
	
}

