namespace Eps.Booking.Application.DataBase.Doctor.Querys;

public interface IGetDoctorByIdQuery
{
    Task<GetDoctorByIdModel>Execute(Guid id);
}