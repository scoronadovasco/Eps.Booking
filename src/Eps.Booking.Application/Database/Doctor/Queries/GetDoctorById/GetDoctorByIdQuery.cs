using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Eps.Booking.Application.DataBase.Doctor.Querys;

public class GetDoctorByIdQuery : IGetDoctorByIdQuery
{
    private readonly IDataBaseService _dataBaseService;
    private readonly IMapper _mapper;

    public GetDoctorByIdQuery(IDataBaseService dataBaseService, IMapper mapper)
    {
        _dataBaseService = dataBaseService;
        _mapper = mapper;
    }

    public async Task<GetDoctorByIdModel> Execute(Guid id)
    {
        var entity = await _dataBaseService.Doctors.FirstOrDefaultAsync(x => x.Id == id);
        return _mapper.Map<GetDoctorByIdModel>(entity);
    }
}