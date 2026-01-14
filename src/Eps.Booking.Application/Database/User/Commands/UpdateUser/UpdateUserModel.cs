using Eps.Booking.Domain.Enum;

namespace Eps.Booking.Application.DataBase.User.Commands;

public class UpdateUserModel
{
    public Guid Id { get; set; }

    public required string UserName { get; set; }

    public required string Email { get; set; }

    public required string Password { get; set; }

    public Role Role { get; set; }
    public bool IsActive { get; set; }


}