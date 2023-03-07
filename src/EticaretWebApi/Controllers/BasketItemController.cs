using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.BasketFeatures.Commands.CreateBasket;
using Application.Features.AppEntities.BasketFeatures.Commands.DeleteBasket;
using Application.Features.AppEntities.BasketFeatures.Commands.UpdateBasket;
using Application.Features.AppEntities.BasketItemFeatures.Commands.CreateBasketItem;
using Application.Features.AppEntities.BasketItemFeatures.Commands.DeleteBasketItem;
using Application.Features.AppEntities.BasketItemFeatures.Commands.DeleteBasketItemByBasketId;
using Application.Features.AppEntities.BasketItemFeatures.Commands.UpdateBasketItem;
using Application.Features.AppEntities.BasketItemFeatures.Queries.GetBasketItemsByBasketId;
using Application.Features.AppEntities.BasketItemFeatures.Queries.GetById;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class BasketItemController : ApiController
    {
        public BasketItemController(IMediator mediator) : base(mediator)
        {
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateBasketItemCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(DeleteBasketItemCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateBasketItemCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetBasketItemsByBasketId(GetBasketItemsByBasketIdQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetById(GetByIdQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> DeleteBasketItemsByBasketId(DeleteBasketItemByBasketIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediatR.Send(request);

            return Ok(response);
        }

    }
}

