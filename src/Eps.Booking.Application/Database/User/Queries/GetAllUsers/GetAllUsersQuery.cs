using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Eps.Booking.Application.DataBase.User.Querys;

public class GetAllUsersQuery: IGetAllUsersQuery
{
    private readonly IDataBaseService _databaseService;
    private readonly IMapper _mapper;

    public GetAllUsersQuery(IMapper mapper, IDataBaseService databaseService)
    {
        _databaseService = databaseService;
        _mapper = mapper;

    }

    public async Task<List<GetAllUsersModel>> Execute()
    {
        var Entities = await _databaseService.Users.ToListAsync();

        return _mapper.Map<List<GetAllUsersModel>>(Entities);
    }
}