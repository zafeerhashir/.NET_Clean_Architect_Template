﻿
using MediatR;
using Application.Dto;
using Application.UseCases.Commons.Bases;

// This is standard template code only for understanding to developer later it will be removed
namespace Application.UseCases.Users.Queries.GetAllUserQuery
{
    public class GetAllUserQuery : IRequest<BaseResponse<IEnumerable<UserDto>>>
    {
    }
}
