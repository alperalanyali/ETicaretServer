using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.RoleFeatures.Queries.GetAllRole;
using Application.Features.AppEntities.RoleFeatures.Queries.GetRoleById;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class RoleController : ApiController
    {
        public RoleController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var request = new GetAllRoleQuery();
            var response = await _mediatR.Send(request);

            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetRoleById(GetRoleByIdQuery request)
        {            
            var response = await _mediatR.Send(request);

            return Ok(response);
        }
    }
}

