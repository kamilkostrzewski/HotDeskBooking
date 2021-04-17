using HotDeskBooking.Application.Auth.Commands.CreateUser;
using HotDeskBooking.Web.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotDeskBooking.Web.Controllers
{
    public class AuthController : BaseController
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserModel createUserModel)
        {
            await _mediator.Send(new CreateUserCommand(createUserModel.Login, createUserModel.Password, createUserModel.FirstName, createUserModel.LastName));

            return Ok();
        }
    }
}