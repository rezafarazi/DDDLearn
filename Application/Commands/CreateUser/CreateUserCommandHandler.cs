using Domain.Entities;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository UserRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {            
            var user = new tbl_users(request.name,request.family,request.username,request.password,request.email);

            return user.id;
        }
    }
}
