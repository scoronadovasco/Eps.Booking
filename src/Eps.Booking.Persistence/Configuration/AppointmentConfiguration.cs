using Eps.Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eps.Booking.Persistence.Configuration;

public class AppointmentConfiguration
{
    public AppointmentConfiguration(EntityTypeBuilder<AppointmentEntity> entityBuilder)
    {
        entityBuilder.HasKey(x => x.Id);
        entityBuilder.Property(x => x.ClinicId).IsRequired();
        entityBuilder.Property(x => x.DoctorId).IsRequired();
        entityBuilder.Property(x => x.PatientId).IsRequired();
    }
}