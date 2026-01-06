using Eps.Booking.Domain.Entities;

namespace Eps.Booking.Application.DataBase.Speciality.Commands;

public interface ICreateSpecialityCommand
{
    Task<SpecialityEntity> Execute(CreateSpecialityModel model);
}