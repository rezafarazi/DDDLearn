using Application.DTO;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Quaries.GetAllUsers
{
    internal class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserDTO>>
    {
        
        private readonly IUserRepository userRepository;

        
        public GetAllUsersQueryHandler(IUserRepository Repo)
        {
            userRepository = Repo;
        }


        public async Task<List<UserDTO>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {

            var users = await userRepository.GetUsersList();


            List<UserDTO> result = new List<UserDTO>();
            foreach (var user in users)
            {
                result.Add(new UserDTO()
                {
                    Id = user.id,
                    Username = user.username,
                    Name = user.name,
                    Family = user.family,
                    Email = user.email,                    
                });
            }

            return result;
        }

    }
}
