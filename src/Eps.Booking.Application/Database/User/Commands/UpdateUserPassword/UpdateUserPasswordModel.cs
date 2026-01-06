namespace Eps.Booking.Application.DataBase.User.Commands;

public class UpdateUserPasswordModel
{
    public Guid Id { get; set; } 
    public required string Password { get; set; }

}