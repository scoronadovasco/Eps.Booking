namespace Eps.Booking.Domain.Entities;

public class DoctorEntity
{
    public int Id { get; set; }
    
    public required string UserId { get; set; }

    public UserEntity? User { get; set; }

    public string? SpecialityId { get; set; }

    public SpecialityEntity? Speciality { get; set; }

}