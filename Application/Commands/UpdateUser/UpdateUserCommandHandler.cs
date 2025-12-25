using Application.DTO;
using Domain.Entities;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UserDTO>
    {

        private readonly IUserRepository user_repository;


        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            user_repository = userRepository;
        }


        public async Task<UserDTO> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new tbl_users(request.id,request.name, request.family, request.username, request.password, request.email);
            await user_repository.UpdateAsync(user);
            return new UserDTO() { Id = user.id, Name = user.name, Family = user.family, Email = user.email, Username = user.username };
        }

    }
}
