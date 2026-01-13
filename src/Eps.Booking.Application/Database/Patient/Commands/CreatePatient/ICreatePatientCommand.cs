namespace Eps.Booking.Application.DataBase.Patient.Commands;

public interface ICreatePatientCommand
{
    Task<CreatePatientModel> Execute(CreatePatientModel model);
}