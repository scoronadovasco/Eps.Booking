namespace Eps.Booking.Application.DataBase.User.Querys;


public interface IGetAllUsersQuery{
    Task<List<GetAllUsersModel>> Execute();
}