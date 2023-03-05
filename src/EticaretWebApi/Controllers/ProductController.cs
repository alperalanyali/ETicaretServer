using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.OrderItemFeatures.Commands.CreateOrderItem;
using Application.Features.AppEntities.ProductFeatures.Commands.CreateProduct;
using Application.Features.AppEntities.ProductFeatures.Commands.DeleteProduct;
using Application.Features.AppEntities.ProductFeatures.Commands.UpdateProduct;
using Application.Features.AppEntities.ProductFeatures.Queries.CheckProductByCodeAndName;
using Application.Features.AppEntities.ProductFeatures.Queries.GetAllProducts;
using Application.Features.AppEntities.ProductFeatures.Queries.GetProductById;
using Application.Features.AppEntities.ProductFeatures.Queries.GetProductIdByCodeAndName;
using Application.Features.AppEntities.ProductFeatures.Queries.GetProductsByCategoryId;
using Domain.Entities;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class ProductController : ApiController
    {
        private readonly AppDbContext _appDBContext;
        public ProductController(IMediator mediator, AppDbContext appDbContext) : base(mediator)
        {
            _appDBContext = appDbContext;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create([FromForm] CreateProductCommand request)
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
        public async Task<IActionResult> Update([FromForm] UpdateProductCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllProducts(GetAllProductsQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> checkProductExist(CheckProductByCodeAndNameQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetProductByCodeAndName(GetProductByCodeAndNameQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetProductById(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediatR.Send(request, cancellationToken);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetProductsByCategoryId(GetProductsByCategoryIdQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);

        }
     }
}

