using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Dtos;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlinePayment_Iyzico.Abstract;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class PaymentController : ControllerBase
    {      
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> PaymentWithIyzico(PaymentAddressDto addressDto)
        {
            var result = await _paymentService.PaymentWithIyzico(addressDto);
            return Ok(new { success = result });
        }
    }
}

