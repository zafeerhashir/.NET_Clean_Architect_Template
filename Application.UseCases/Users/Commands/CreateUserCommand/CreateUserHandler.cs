using MediatR;
using Domain.Entities;
using Application.Interface.Persistence;
using Application.UseCases.Commons.Bases;

// This is standard template code only for understanding to developer later it will be removed
namespace Application.UseCases.Users.Commands.CreateUserCommand
{
    internal class CreateUserHandler : IRequestHandler<CreateUserCommand, BaseResponse<bool>>
    {
        private readonly IUserRepository _user;

        public CreateUserHandler(IUserRepository user)
        {
            _user = user;
        }
        public  async Task<BaseResponse<bool>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            await _user.CreateUserAsync(new User() { Name = request.Name, Id = request.Id });
            
            return new BaseResponse<bool>() { Success = true };

        }
    }
}
