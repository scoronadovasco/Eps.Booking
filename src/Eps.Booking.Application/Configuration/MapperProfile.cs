using AutoMapper;
using Eps.Booking.Application.DataBase.Speciality.Commands;
using Eps.Booking.Application.DataBase.User.Commands;
using Eps.Booking.Application.DataBase.User.Querys;
using Eps.Booking.Domain.Entities;

namespace Eps.Booking.Application;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<UserEntity,CreateUserModel>().ReverseMap();
        CreateMap<UserEntity,UpdateUserModel>().ReverseMap();
        CreateMap<UserEntity,GetAllUsersModel>().ReverseMap();
        CreateMap<UserEntity,GetUserByIdModel>().ReverseMap();
        CreateMap<SpecialityEntity,CreateSpecialityModel>().ReverseMap();
        CreateMap<SpecialityEntity,UpdateSpecialityModel>().ReverseMap();
    }
}