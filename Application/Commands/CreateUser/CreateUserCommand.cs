using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.CreateUser
{
    public record CreateUserCommand(string name, string family, string email, string username, string password) : IRequest<int>;
}
