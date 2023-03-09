
using System;
using Application.Features.AppEntities.IyzicoSettingFeatures.Commands.UpdateIyzicoSetting;
using Application.Features.AppEntities.IyzicoSettingFeatures.Queries.GetFirstIyzicoSetting;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EticaretWebApi.Controllers
{
    public class IyzicoSettingController : ApiController
    {
        public IyzicoSettingController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateIyzicoSettingCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediatR.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetFirst(GetFirstIyzicoSettingQuery request)
        {
            var response = await _mediatR.Send(request);

            return Ok(response);
        }
    }
}

