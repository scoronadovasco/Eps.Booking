namespace Eps.Booking.Application.DataBase.User.Commands;

public interface IUpdateUserPasswordCommand
{
    Task<bool> Execute(UpdateUserPasswordModel model);
}