using Application.DTO;
using Application.Quaries.GetUserById;
using Domain.Repositories;
using MediatR;

public class GetUserByIdQuaryHandler : IRequestHandler<GetUserByIdQuary, UserDTO>
{
    private readonly IUserRepository _userRepo;

    public GetUserByIdQuaryHandler(IUserRepository userRepo)
    {
        _userRepo = userRepo;
    }

    public async Task<UserDTO> Handle(GetUserByIdQuary request, CancellationToken cancellationToken)
    {
        var user = await _userRepo.GetByIdAsync(request.id);

        return new UserDTO() {Id = user.id,Name = user.name,Family = user.family , Email=user.email, Username = user.username};
    }
}
