namespace Eps.Booking.Application.DataBase.Doctor.Commands;

public interface ICreateDoctorCommand
{
    Task<CreateDoctorModel> Execute(CreateDoctorModel model);
}