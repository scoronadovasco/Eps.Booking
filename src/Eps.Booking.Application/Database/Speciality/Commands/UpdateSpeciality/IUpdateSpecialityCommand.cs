namespace Eps.Booking.Application.DataBase.Speciality.Commands;

public interface IUpdateSpecialityCommand
{
    Task<UpdateSpecialityModel> Execute(UpdateSpecialityModel model);
}