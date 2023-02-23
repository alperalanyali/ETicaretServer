using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EticaretWebApi.Abstractions
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ApiController:ControllerBase
	{
        protected readonly IMediator _mediatR;
        public ApiController(IMediator mediator)
		{
            _mediatR = mediator;
		}
	}
}

