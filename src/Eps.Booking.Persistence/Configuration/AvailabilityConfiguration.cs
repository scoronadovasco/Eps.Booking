using Eps.Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eps.Booking.Persistence.Configuration;

public class AvailabilityConfiguration
{
    public AvailabilityConfiguration(EntityTypeBuilder<AvailabilityEntity> entityBuilder)
    {
        entityBuilder.HasKey(x => x.Id);
        entityBuilder.Property(x =>x.DoctorId).IsRequired();
        entityBuilder.Property(x =>x.DayOfWeek).HasMaxLength(20);
    }
}