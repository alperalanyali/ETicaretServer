using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EticaretWebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EticaretWebApi.Controllers
{
    public class AddressController : ApiController
    {
        // GET: /<controller>/
        public AddressController(IMediator mediator) : base(mediator)
        {
        }
    }
}

