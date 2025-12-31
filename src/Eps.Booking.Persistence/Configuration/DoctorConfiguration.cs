using Eps.Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eps.Booking.Persistence.Configuration;

public class DoctorConfiguration
{
    public DoctorConfiguration(EntityTypeBuilder<DoctorEntity> entityBuilder)
    {
        entityBuilder.HasKey(x => x.Id);
        entityBuilder.Property(x => x.UserId).IsRequired();
        entityBuilder.Property(x => x.SpecialityId).IsRequired();

        entityBuilder.HasMany(x => x.Appointments).
        WithOne(x => x.Doctor).
        HasForeignKey(x => x.DoctorId);
    }
}