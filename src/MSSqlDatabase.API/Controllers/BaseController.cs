using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MSSqlDatabase.API.Controllers
{
    [ApiController]
    [Route(RoutingConstants.ApiControllerBase)]
    public class BaseController:ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator =>
            _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}