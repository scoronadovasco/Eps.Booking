using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Eps.Booking.Application.DataBase.Patient.Queries;

public class GetAllPatientQuery: IGetAllPatientQuery
{
    private readonly IDataBaseService _dataBaseService;
    private readonly IMapper _mapper;

    public GetAllPatientQuery(IMapper mapper, IDataBaseService dataBaseService)
    {
        _dataBaseService = dataBaseService;
        _mapper = mapper;
    }

    public async Task<List<GetAllPatientModel>> Execute()
    {
        var entities = await _dataBaseService.Patients.ToListAsync();

        return _mapper.Map<List<GetAllPatientModel>>(entities);
    }
}
