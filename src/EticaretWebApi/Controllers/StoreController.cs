using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.StoreFeatures.Commands.CreateStore;
using Application.Features.AppEntities.StoreFeatures.Commands.UpdateStore;
using Application.Features.AppEntities.StoreFeatures.Queries.GetAll;
using Azure.Core;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class StoreController : ApiController
    {
        public StoreController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateStoreCommand request)
        {
            var response = await _mediatR.Send(request);

            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateStoreCommand request) {

            var response = await _mediatR.Send(request);

            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll() {
            var request = new GetAllStoreQuery();
            var response = await _mediatR.Send(request);

            return Ok(response);
        }
    }
}

