using AutoMapper;
using Eps.Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eps.Booking.Application.DataBase.User.Querys;

public class GetUserByIdQuery: IGetUserByIdQuery
{
    private readonly IDataBaseService _dataBaseService;
    private readonly IMapper _mapper;

    public GetUserByIdQuery(IDataBaseService dataBaseService, IMapper mapper)
    {
        _dataBaseService = dataBaseService;
        _mapper = mapper;
    }

    public async Task<GetUserByIdModel> Execute(Guid id)
    {
        var entity = await _dataBaseService.Users.FirstOrDefaultAsync(x => x.Id == id);

        return _mapper.Map<GetUserByIdModel>(entity);
    }
}