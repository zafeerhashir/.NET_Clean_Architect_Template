using MediatR;
using Application.Dto;
using Application.UseCases.Commons.Bases;

// This is standard template code only for understanding to developer later it will be removed
namespace Application.UseCases.Users.Commands.GetByIdUserQuery
{
    public class GetByIdUserQuery : IRequest<BaseResponse<UserDto>>
    {
        public required int Id { get; set; }

    }
}
