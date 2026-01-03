using Eps.Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eps.Booking.Application.DataBase;

public interface IDataBaseService
{
    DbSet<UserEntity> Users { get; set; }

    DbSet<DoctorEntity> Doctors { get; set; }

    DbSet<AppointmentEntity> Appointments { get; set; }

    DbSet<AvailabilityEntity> Availabilities { get; set; }

    DbSet<SpecialityEntity> Specialities { get; set; }

    DbSet<ClinicEntity> Clinics { get; set; }

    DbSet<PatientEntity> Patients { get; set; }

    Task<bool> SaveAsync();
}