using MediatR;
using AutoMapper;
using Application.Dto;
using Domain.Entities;
using Application.Interface.Persistence;
using Application.UseCases.Commons.Bases;


// This is standard template code only for understanding to developer later it will be removed
namespace Application.UseCases.Users.Commands.GetByIdUserQuery
{
    public class GetByIdUserHandler : IRequestHandler<GetByIdUserQuery, BaseResponse<UserDto>>
    {
        private readonly IUserRepository _user;
        private readonly IMapper _mapper;

        public GetByIdUserHandler(IUserRepository user, IMapper mapper)
        {
            _user = user;
            _mapper = mapper;
        }
        public async Task<BaseResponse<UserDto>> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {

            User  user = await _user.GetUserAsync(request.Id);

            return new BaseResponse<UserDto>() { Success = true, Data = _mapper.Map<UserDto>(user) };
        }
    }
}
