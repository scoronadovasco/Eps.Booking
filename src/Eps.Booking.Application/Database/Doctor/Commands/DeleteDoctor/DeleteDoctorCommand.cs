using Microsoft.EntityFrameworkCore;

namespace Eps.Booking.Application.DataBase.Doctor.Commands;

public class DeleteDoctorCommand: IDeleteDoctorCommand
{
    private readonly IDataBaseService _dataBaseService;
    public DeleteDoctorCommand(IDataBaseService dataBaseService)
    {
        _dataBaseService = dataBaseService;
    }
    public async Task<bool> Execute(Guid id)
    {
        var entity = await _dataBaseService.Doctors.FirstOrDefaultAsync(x => x.Id == id);

        if (entity == null)
        {
            return false;
        }
        else
            _dataBaseService.Doctors.Remove(entity);
            return await _dataBaseService.SaveAsync();
    }
}