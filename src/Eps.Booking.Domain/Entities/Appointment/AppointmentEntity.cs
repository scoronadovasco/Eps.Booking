using Eps.Booking.Domain.Enum;

namespace Eps.Booking.Domain.Entities;


public class AppointmentEntity
{
    public Guid Id { get; set; }
    public Guid DoctorId { get; set; }
    public DoctorEntity Doctor { get; set; } = default!;
    public Guid PatientId { get; set; }
    public PatientEntity Patient { get; set; } = default!;
    public Guid ClinicId { get; set; }
    public ClinicEntity Clinic { get; set; } = default!;
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public AppointmentStatus Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}