using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly IMediator? _mediator;
        protected IMediator? Mediator
        {
            get
            {
                return _mediator;
            }
        }

        public BaseController()
        {
            _mediator = HttpContext.RequestServices.GetService<IMediator?>();
        }
    }
}
