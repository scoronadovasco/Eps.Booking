namespace Eps.Booking.Application.DataBase.Doctor.Querys;

public class GetDoctorByIdModel
{
    public Guid Id { get; set; }
    public required string FullName { get; set; }
    public required Guid UserId { get; set; }
    public Guid? SpecialityId { get; set; }
    public DateTime CreateAt { get; set; }
}