using AutoMapper;
using Eps.Booking.Domain.Entities;

namespace Eps.Booking.Application.DataBase.Patient.Commands;

public class CreatePatientCommand: ICreatePatientCommand
{
    private readonly IDataBaseService _dataBaseService;
    private readonly IMapper _mapper;

    public CreatePatientCommand(IDataBaseService dataBaseService, IMapper mapper)
    {
        _dataBaseService = dataBaseService;
        _mapper = mapper;
    }

    public async Task<CreatePatientModel> Execute(CreatePatientModel model)
    {
        var entity = _mapper.Map<PatientEntity>(model);
        _dataBaseService.Patients.Add(entity);
        await _dataBaseService.SaveAsync();
        return model;
    }
}