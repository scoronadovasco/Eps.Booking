namespace Eps.Booking.Domain.Entities;

public class PatientEntity
{
    public Guid Id { get; set; }

    public required string FullName { get; set; }
    public Guid UserId { get; set; }
    public UserEntity? User { get; set; }
    public required string DocumentNumber { get; set; }
    public DateTime BirthDate { get; set; }

    public DateTime CreateAt { get; set; }

    public ICollection<AppointmentEntity> Appointments { get; set; }
       = new List<AppointmentEntity>();

}