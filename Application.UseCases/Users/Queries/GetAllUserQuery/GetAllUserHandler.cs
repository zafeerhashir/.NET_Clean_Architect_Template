using MediatR;
using AutoMapper;
using Domain.Entities;
using Application.Dto;
using Application.Interface.Persistence;
using Application.UseCases.Commons.Bases;

// This is standard template code only for understanding to developer later it will be removed
namespace Application.UseCases.Users.Queries.GetAllUserQuery
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserQuery, BaseResponse<IEnumerable<UserDto>>>
    {

        private readonly IUserRepository _user;
        private readonly IMapper _mapper;


        public GetAllUserHandler(IUserRepository user, IMapper mapper)
        {
            _user = user;
            _mapper = mapper;
        }

        public async Task<BaseResponse<IEnumerable<UserDto>>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<User> users =  await _user.GetAllUsersAsync();

            return new BaseResponse<IEnumerable<UserDto>>()
            {   Data = _mapper.Map<IEnumerable<UserDto>>(users),
                Success = true,
            };
        }
    }
}
