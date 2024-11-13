using AutoMapper;
using Domain.Entities;
using Application.Dto;

namespace Application.UseCases.Commons.Mappings
{
    public class CustomerMapper : Profile
    {
        public CustomerMapper()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}