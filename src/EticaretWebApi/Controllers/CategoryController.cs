using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AppEntities.CategoryFeatures.Commands.CreateCategory;
using Application.Features.AppEntities.CategoryFeatures.Commands.DeleteCategory;
using Application.Features.AppEntities.CategoryFeatures.Commands.UpdateCategory;
using Application.Features.AppEntities.CategoryFeatures.Queries.GetAll;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class CategoryController : ApiController
    {
        public CategoryController(IMediator mediator) : base(mediator)
        {
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var request = new GetAllQuery();

            var response = await _mediatR.Send(request);

            return Ok(response);

        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateCategoryCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediatR.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateCategoryCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediatR.Send(request, cancellationToken);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(DeleteCategoryCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediatR.Send(request, cancellationToken);
            return Ok(response);
        }

    }
}

