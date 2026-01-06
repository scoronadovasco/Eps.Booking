namespace Eps.Booking.Application.DataBase.User.Querys;

public interface IGetUserByIdQuery
{
    Task<GetUserByIdModel> Execute(Guid id);
}