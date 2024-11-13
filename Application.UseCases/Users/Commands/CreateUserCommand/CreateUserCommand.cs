using MediatR;
using Application.UseCases.Commons.Bases;

// This is standard template code only for understanding to developer later it will be removed
namespace Application.UseCases.Users.Commands.CreateUserCommand
{   
    public class CreateUserCommand: IRequest<BaseResponse<bool>>
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
    }
}
