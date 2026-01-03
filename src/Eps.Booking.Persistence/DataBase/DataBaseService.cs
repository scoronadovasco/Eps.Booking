using Eps.Booking.Application.DataBase;
using Eps.Booking.Domain.Entities;
using Eps.Booking.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Eps.Booking.Persistence.DataBase;


public class DataBaseService : DbContext, IDataBaseService
{
    public DataBaseService(DbContextOptions options) : base(options)
    {

    }

    public DbSet<UserEntity> Users { get; set; }
    public DbSet<DoctorEntity> Doctors { get; set; }

    public DbSet<AppointmentEntity> Appointments { get; set; }

    public DbSet<AvailabilityEntity> Availabilities { get; set; }

    public DbSet<SpecialityEntity> Specialities { get; set; }

    public DbSet<ClinicEntity> Clinics {get; set;}

    public DbSet<PatientEntity> Patients { get; set; }

    public async Task<bool> SaveAsync()
    {
        return await SaveChangesAsync() > 0;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        EntityConfiguration(modelBuilder);
    }

    private void EntityConfiguration(ModelBuilder modelBuilder)
    {
        new UserConfiguration(modelBuilder.Entity<UserEntity>());
        new DoctorConfiguration(modelBuilder.Entity<DoctorEntity>());
        new AppointmentConfiguration(modelBuilder.Entity<AppointmentEntity>());
        new AvailabilityConfiguration(modelBuilder.Entity<AvailabilityEntity>());
        new SpecialityConfiguration(modelBuilder.Entity<SpecialityEntity>());
        new ClinicConfiguration(modelBuilder.Entity<ClinicEntity>());
        new PatientConfiguration(modelBuilder.Entity<PatientEntity>());
    }
}