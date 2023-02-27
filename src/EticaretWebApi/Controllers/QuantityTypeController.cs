using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.QuantityTypeFeatures.Commands.CreateQuantityType;
using Application.Features.AppEntities.QuantityTypeFeatures.Queries.GetAllQuantityTypes;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class QuantityTypeController : ApiController
    {
        public QuantityTypeController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateQuantityTypeCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllQuantityTypes()
        {
            var request = new GetAllQuantityTypesQuery();
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
    }
}

