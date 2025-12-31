using Eps.Booking.Domain.Entities;

namespace Eps.Booking.Domain;

public class DoctorClinic
{
    public Guid Id { get; set; }
    public Guid DoctorId { get; set; }
    public DoctorEntity Doctor { get; set; } = default!;

    public Guid ClinicId { get; set; }
    public ClinicEntity Clinic { get; set; } = default!;
}