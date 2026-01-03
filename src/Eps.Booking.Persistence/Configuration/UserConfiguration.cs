using Eps.Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eps.Booking.Persistence.Configuration;


public class UserConfiguration
{
    public UserConfiguration(EntityTypeBuilder<UserEntity> entityBuilder)
    {
        entityBuilder.HasKey(x => x.Id);
        entityBuilder.Property(x => x.UserName).IsRequired();
        entityBuilder.Property(x => x.Password).IsRequired();
        entityBuilder.Property(x => x.Role).IsRequired();

        entityBuilder.HasOne(x => x.Doctor).
        WithOne(x => x.User).HasForeignKey<DoctorEntity>(x => x.UserId);

        entityBuilder.HasOne(x => x.Patient).
        WithOne(x => x.User).HasForeignKey<PatientEntity>(x => x.UserId);
    }
}