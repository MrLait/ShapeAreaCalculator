using Microsoft.AspNetCore.Mvc;
using MsSqlLib.Application.Common.Models;
using MsSqlLib.Application.Cqrs.Products.Queries;
using MsSqlLib.Application.Dto;

namespace MSSqlDatabase.API.Controllers
{
    [ApiController]
    [Route(RoutingConstants.ApiController)]
    public class ProductController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<ServiceResult<List<ProductDto>>>> Get() 
        {
            var vm = await Mediator.Send(new GetProductsQuery());
            return Ok(vm);
        }
    }
}
