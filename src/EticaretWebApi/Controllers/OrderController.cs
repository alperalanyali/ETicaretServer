using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.OrderFeatures.Commands.CreateOrder;
using Application.Features.AppEntities.OrderFeatures.Commands.DeleteOrder;
using Application.Features.AppEntities.OrderFeatures.Commands.UpdateOrder;
using Application.Features.AppEntities.OrderFeatures.Queries.GetAllOrders;
using Application.Features.AppEntities.OrderFeatures.Queries.GetOrderById;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class OrderController : ApiController
    {
        public OrderController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateOrderCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(DeleteOrderCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateOrderCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllOrders(GetAllOrdersQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetOrderById(GetOrderByIdQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
    }
}

