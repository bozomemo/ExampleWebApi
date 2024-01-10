using Application.Features.Users.Commands.CreateUserCommand;
using Application.Features.Users.Queries.GetAllUsersQuery;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await Mediator!.Send(new GetAllUsersQuery());
            return Ok(users);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserCommand createUserCommand)
        {
            var newUser = await Mediator!.Send(createUserCommand);
            return Ok(newUser);
        }
    }
}
