namespace Eps.Booking.Application.DataBase.Doctor.Commands;

public interface IUpdateDoctorCommand
{
    Task<UpdateDoctorModel> Execute(UpdateDoctorModel model);
}