using AutoMapper;
using Eps.Booking.Application.DataBase.User.Commands;
using Eps.Booking.Domain.Entities;

namespace Eps.Booking.Application;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<UserEntity,CreateUserModel>().ReverseMap();
    }
}