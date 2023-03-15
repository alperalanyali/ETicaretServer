using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.UserFeatures.Queries.GetAllUser;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class UserController : ApiController
    {
        public UserController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllUser(GetAllUserQuery request)
        {
            var response = await _mediatR.Send(request);

            return Ok(response);
        }
    }
}

