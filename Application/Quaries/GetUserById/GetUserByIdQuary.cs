using Application.DTO;
using MediatR;

namespace Application.Quaries.GetUserById
{
    public record GetUserByIdQuary(int id) : IRequest<UserDTO>;
}
