using AutoMapper;
using Eps.Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eps.Booking.Application.DataBase.Doctor.Querys;

public class GetAllDoctorsQuery: IGetAllDoctorsQuery
{
    private readonly IDataBaseService _dataBaseService;
    private readonly IMapper _mapper;

    public GetAllDoctorsQuery(IDataBaseService dataBaseService, IMapper mapper)
    {
        _dataBaseService = dataBaseService;
        _mapper = mapper;
    }

    public async Task<List<GetAllDoctorsModel>> Execute()
    {
        var Entities = await _dataBaseService.Doctors.ToListAsync();
        return _mapper.Map<List<GetAllDoctorsModel>>(Entities);
    }
}