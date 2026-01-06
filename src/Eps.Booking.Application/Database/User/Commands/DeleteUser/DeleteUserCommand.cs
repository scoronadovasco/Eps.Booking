using Microsoft.EntityFrameworkCore;

namespace Eps.Booking.Application.DataBase.User.Commands;

public class DeleteUserCommand : IDeleteUserCommand
{
    private readonly IDataBaseService _databaseService;

    public DeleteUserCommand(IDataBaseService dataBaseService)
    {
        _databaseService = dataBaseService;
    }

    public async Task<bool> Execute(Guid userid)
    {
        var entity =  await _databaseService.Users.FirstOrDefaultAsync(x => x.Id == userid);

        if (entity == null)
        {
            return false;
        }
        else
            _databaseService.Users.Remove(entity);
            return await _databaseService.SaveAsync();
    }
}