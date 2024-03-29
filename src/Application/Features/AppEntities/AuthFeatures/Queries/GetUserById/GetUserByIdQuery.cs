﻿using System;
using Application.Messaging;
using Domain.Entities.Identity;

namespace Application.Features.AppEntities.AuthFeatures.Queries.GetUserById
{
	public record GetUserByIdQuery(
			string UserId
		):IQuery<GetUserByIdQueryResponse>;
	
}

