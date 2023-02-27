using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.OrderItemFeatures.Commands.CreateOrderItem;
using Application.Features.AppEntities.ProductFeatures.Commands.CreateProduct;
using Application.Features.AppEntities.ProductFeatures.Commands.DeleteProduct;
using Application.Features.AppEntities.ProductFeatures.Commands.UpdateProduct;
using Application.Features.AppEntities.ProductFeatures.Queries.GetAllProducts;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class ProductController : ApiController
    {
        public ProductController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateProductCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(DeleteProductCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateProductCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllProducts()
        {
            var request =new  GetAllProductsQuery();
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
    }
}

