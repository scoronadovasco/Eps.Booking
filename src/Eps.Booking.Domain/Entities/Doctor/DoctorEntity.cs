namespace Eps.Booking.Domain.Entities;

public class DoctorEntity
{
    public Guid Id { get; set; }
    
    public required string FullName { get; set; }
    public required Guid UserId { get; set; }

    public UserEntity? User { get; set; }

    public Guid? SpecialityId { get; set; }

    public SpecialityEntity? Speciality { get; set; }
    public DateTime CreateAt {get; set;}

    public ICollection<AvailabilityEntity> Availabilities { get; set; } = new List<AvailabilityEntity>();
    public ICollection<AppointmentEntity> Appointments { get; set; } = new List<AppointmentEntity>();

    public ICollection<DoctorClinic>? DoctorClinics {get; set;}

}