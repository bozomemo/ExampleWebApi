﻿using Application.Features.Users.Dtos;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Commands.CreateUserCommand
{
    public class CreateUserCommand : IRequest<UserDto>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set;}
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
