using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.BasketFeatures.Commands.CreateBasket;
using Application.Features.AppEntities.BasketFeatures.Commands.DeleteBasket;
using Application.Features.AppEntities.BasketFeatures.Commands.UpdateBasket;
using Application.Features.AppEntities.BasketFeatures.Queries.GetBasketById;
using Application.Features.AppEntities.BasketFeatures.Queries.GetBasketIdByUserId;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class BasketController : ApiController
    {
        public BasketController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateBasketCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(DeleteBasketCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateBasketCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetBasketIdByUserId(GetBasketIdByUserIdQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetBasketById(GetBasketByIdQuery request)
        {
            var response = await _mediatR.Send(request);

            return Ok(response);
        }
    }
}

