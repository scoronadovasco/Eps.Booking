namespace Eps.Booking.Application.DataBase.Doctor.Commands;

public interface IUpdateDoctorCommand
{
    Task<UpdateDoctorCommand> Execute(UpdateDoctorCommand model);
}