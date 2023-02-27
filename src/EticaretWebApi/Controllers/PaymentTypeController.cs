using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.PaymentTypeFeatures.Commands.CreatePaymentType;
using Application.Features.AppEntities.PaymentTypeFeatures.Queries.GetAllPaymentType;
using Application.Features.AppEntities.PaymentTypeFeatures.Queries.GetPaymentTypeById;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class PaymentTypeController : ApiController
    {
        public PaymentTypeController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreatePaymentTypeCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllPaymentType()
        {
            var request = new GetAllPaymentTypeQuery();
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllPGetPaymentTypeByIdaymentType(GetPaymentTypeByIdQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
    }
}

