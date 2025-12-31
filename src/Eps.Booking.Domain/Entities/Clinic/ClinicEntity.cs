namespace Eps.Booking.Domain.Entities;

public class ClinicEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    
    public required string Address { get; set; }
}