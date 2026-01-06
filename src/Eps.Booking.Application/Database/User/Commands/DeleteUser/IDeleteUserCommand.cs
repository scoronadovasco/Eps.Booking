namespace Eps.Booking.Application.DataBase.User.Commands;


public interface IDeleteUserCommand
{
     Task<bool> Execute(Guid userid);
}