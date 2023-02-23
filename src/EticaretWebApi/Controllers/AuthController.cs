using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.AuthFeatures.Commands.CreateUser;
using Application.Features.AppEntities.AuthFeatures.Commands.Login;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
       public async Task<IActionResult> CreateUser(CreateUserCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediatR.Send(request);

            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediatR.Send(request);

            return Ok(response);
        }
    }
}

