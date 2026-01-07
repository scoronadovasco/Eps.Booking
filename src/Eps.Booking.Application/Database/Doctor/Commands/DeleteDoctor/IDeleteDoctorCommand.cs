namespace Eps.Booking.Application.DataBase.Doctor.Commands;

public interface IDeleteDoctorCommand
{
    Task<bool> Execute(Guid id);
}