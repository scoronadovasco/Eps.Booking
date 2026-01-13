using AutoMapper;
using Eps.Booking.Domain.Entities;

namespace Eps.Booking.Application.DataBase.Patient.Commands;

public class UpdatePatientCommand: IUpdatePatientCommand
{
    private readonly IDataBaseService _dataBaseService;
    private readonly IMapper _mapper;

    public UpdatePatientCommand(IDataBaseService dataBaseService, IMapper mapper)
    {
        _dataBaseService = dataBaseService;
        _mapper = mapper;
    }

    public async Task<UpdatePatientModel> Execute(UpdatePatientModel model)
    {
        var entity = _mapper.Map<PatientEntity>(model);

        _dataBaseService.Patients.Update(entity);
        await _dataBaseService.SaveAsync();

        return model;
    }
}