namespace Eps.Booking.Application.DataBase.Patient.Queries;

public interface IGetAllPatientQuery
{
    Task<List<GetAllPatientModel>> Execute();
}