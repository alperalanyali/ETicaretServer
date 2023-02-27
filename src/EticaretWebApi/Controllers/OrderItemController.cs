using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.OrderItemFeatures.Commands.CreateOrderItem;
using Application.Features.AppEntities.OrderItemFeatures.Commands.DeleteOrderItem;
using Application.Features.AppEntities.OrderItemFeatures.Commands.UpdateOrderItem;
using Application.Features.AppEntities.OrderItemFeatures.Queries.GetAllOrderItems;
using Application.Features.AppEntities.OrderItemFeatures.Queries.GetOrderItemsByOrderId;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class OrderItemController : ApiController
    {
        public OrderItemController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateOrderItemCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(DeleteOrderItemCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateOrderItemCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllOrderItem(GetAllOrderItemsQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetOrderItemsByOrderId(GetOrderItemsByOrderIdQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
    }
}

