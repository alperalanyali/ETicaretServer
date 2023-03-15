using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.ProductStoreFeatures.Commands.CreateProductStore;
using Application.Features.AppEntities.ProductStoreFeatures.Commands.DeleteProductStore;
using Application.Features.AppEntities.ProductStoreFeatures.Commands.UpdateProductStore;
using Application.Features.AppEntities.ProductStoreFeatures.Queries.GetAllProductStore;
using Application.Features.AppEntities.ProductStoreFeatures.Queries.GetProductStoreByCategoryId;
using Azure.Core;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class ProductStoreController : ApiController
    {
        public ProductStoreController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create([FromForm]CreateProductStoreCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediatR.Send(request,cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update([FromForm]UpdateProductStoreCommand request,CancellationToken cancellationToken)
        {

            var response = await _mediatR.Send(request,cancellationToken);

            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(DeleteProductStoreCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetAll(GetAllProductStoreQuery request)
        {
            
            var response = await _mediatR.Send(request);

            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetProductStoresByCategoryId(GetProductStoreByCategoryIdQuery request)
        {            
            var response = await _mediatR.Send(request);

            return Ok(response);

        }

    }
}

