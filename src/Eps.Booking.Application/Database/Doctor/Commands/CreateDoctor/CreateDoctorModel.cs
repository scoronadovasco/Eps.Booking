namespace Eps.Booking.Application.DataBase.Doctor.Commands;

public class CreateDoctorModel
{
    public required Guid UserId { get; set; }
    public required string FullName { get; set; }
    public Guid? SpecialityId { get; set; }
    public DateTime CreateAt { get; set; }

}