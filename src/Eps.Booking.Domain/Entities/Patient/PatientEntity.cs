namespace Eps.Booking.Domain.Entities;

public class PatientEntity
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public UserEntity User { get; set; }

    public required string DocumentNumber { get; set; }

    public DateTime BirthDate {get; set;}
    
}