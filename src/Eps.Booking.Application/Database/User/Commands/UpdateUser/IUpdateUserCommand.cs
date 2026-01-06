
namespace Eps.Booking.Application.DataBase.User.Commands;

public interface IUpdateUserCommand
{
    Task<UpdateUserModel> Execute(UpdateUserModel model);
}