namespace Eps.Booking.Application.DataBase.Patient.Commands;

public interface IUpdatePatientCommand
{
    Task<UpdatePatientModel> Execute(UpdatePatientModel model);
}