using Eps.Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eps.Booking.Persistence.Configuration;

public class PatientConfiguration
{
    public PatientConfiguration(EntityTypeBuilder<PatientEntity> entityBuilder)
    {
        entityBuilder.HasKey(x => x.Id);
        entityBuilder.Property(x => x.DocumentNumber).IsRequired();
        entityBuilder.Property(x => x.UserId).IsRequired();
        entityBuilder.Property(x => x.FullName).IsRequired();

        entityBuilder.HasMany(x=>x.Appointments)
        .WithOne(x => x.Patient).HasForeignKey(x => x.PatientId);
    }
}