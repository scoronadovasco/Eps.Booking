namespace Eps.Booking.Application.DataBase.Patient.Commands;

public class CreatePatientModel
{
    public Guid Id { get; set; }
    public required string FullName { get; set; }
    public Guid UserId { get; set; }
    public required string DocumentNumber { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime CreateAt { get; set; }

}