namespace Eps.Booking.Application.DataBase.Doctor.Commands;

public class UpdateDoctorModel
{
    public Guid Id { get; set; }

    public string? FullName { get; set; }
    public Guid UserId { get; set; }

    public Guid? SpecialityId { get; set; }

}