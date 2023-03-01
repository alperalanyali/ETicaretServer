using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.ProductCategoryFeatures.Commands.CreateProductCategory;
using Application.Features.AppEntities.ProductCategoryFeatures.Commands.DeleteProductCategory;
using Application.Features.AppEntities.ProductCategoryFeatures.Commands.UpdateProductCategory;
using Application.Features.AppEntities.ProductCategoryFeatures.Queries.GetAllProductCategory;
using Application.Features.AppEntities.ProductCategoryFeatures.Queries.GetProductCategoriesByCategoryId;
using Application.Features.AppEntities.ProductCategoryFeatures.Queries.GetProductCategoriesByProductId;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class ProductCategoryController : ApiController
    {
        public ProductCategoryController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateProductCategoryCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(DeleteProductCategoryCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateProductCategoryCommand request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllProductCategory(GetAllProductCategoryQuery request)
        {           
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetProductCategoriesByCategoryId(GetProductCategoriesByCategoryIdQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetProductCategoriesByProductId(GetProductCategoriesByProductIdQuery request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }
    }
}

