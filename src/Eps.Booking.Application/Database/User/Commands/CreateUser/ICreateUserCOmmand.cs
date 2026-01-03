namespace Eps.Booking.Application.DataBase.User.Commands;

public interface ICreateUserCommand
{
    Task<CreateUserModel> Execute(CreateUserModel model);
}