using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.AddressFeatures.Commands.CreateAddress;
using Application.Features.AppEntities.AddressFeatures.Commands.DeleteAddress;
using Application.Features.AppEntities.AddressFeatures.Commands.UpdateAddress;
using Application.Features.AppEntities.AddressFeatures.Queries.GetAddressById;
using Application.Features.AppEntities.AddressFeatures.Queries.GetAddressByUserId;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class AddressController : ApiController
    {
        // GET: /<controller>/
        public AddressController(IMediator mediator) : base(mediator)
        {
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> CreateAddress(CreateAddressCommand request)
        {
            var response  = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateAddressCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(DeleteAddressCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetAddressById(GetAddressByIdCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetAddressByUserId(GetAddressByUserIdQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
    }
}

