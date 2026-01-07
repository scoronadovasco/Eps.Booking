namespace Eps.Booking.Application.DataBase.Doctor.Querys;

public interface IGetAllDoctorsQuery
{
    Task<List<GetAllDoctorsModel>> Execute();
}