using Eps.Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eps.Booking.Persistence.Configuration;


public class SpecialityConfiguration
{
    public SpecialityConfiguration(EntityTypeBuilder<SpecialityEntity> entityBuilder)
    {
        entityBuilder.HasKey(x => x.Id);
        entityBuilder.Property(x => x.Description).IsRequired();
    }
}