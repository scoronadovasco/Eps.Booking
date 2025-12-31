namespace Eps.Booking.Domain.Entities;

public class DoctorEntity
{
    public Guid Id { get; set; }
    
    public required string UserId { get; set; }

    public UserEntity? User { get; set; }

    public string? SpecialityId { get; set; }

    public SpecialityEntity? Speciality { get; set; }

    public ICollection<AvailabilityEntity> Availabilities { get; set; } = new List<AvailabilityEntity>();
    public ICollection<AppointmentEntity> Appointments { get; set; } = new List<AppointmentEntity>();

    public ICollection<DoctorClinic>? DoctorClinics {get; set;}

}