namespace Eps.Booking.Application.DataBase.Speciality.Commands;

public class UpdateSpecialityModel
{
    public Guid Id { get; set; }
    public required string Description { get; set; }
}