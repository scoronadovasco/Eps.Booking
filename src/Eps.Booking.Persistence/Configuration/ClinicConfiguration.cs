using Eps.Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Eps.Booking.Persistence.Configuration;


public class ClinicConfiguration
{
    public ClinicConfiguration(EntityTypeBuilder<ClinicEntity> entityBuilder)
    {
        entityBuilder.HasKey(x => x.Id);
        entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(50);
    }
}