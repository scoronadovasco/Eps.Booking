using AutoMapper;
using Eps.Booking.Domain.Entities;

namespace Eps.Booking.Application.DataBase.Doctor.Commands;

public class UpdateDoctorCommand: IUpdateDoctorCommand
{
    private readonly IDataBaseService _dataBaseService;
    private readonly IMapper _mapper;

    public UpdateDoctorCommand(IDataBaseService dataBaseService, IMapper mapper)
    {
        _dataBaseService = dataBaseService;
        _mapper = mapper;
    }

    public async Task<UpdateDoctorCommand> Execute(UpdateDoctorCommand model)
    {
        var entity = _mapper.Map<DoctorEntity>(model);

        _dataBaseService.Doctors.Update(entity);

        await _dataBaseService.SaveAsync();

        return model;
    }
}