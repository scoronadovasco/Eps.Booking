using AutoMapper;
using Eps.Booking.Application.DataBase.Doctor.Commands;
using Eps.Booking.Domain.Entities;

namespace Eps.Booking.Application.DataBase.Speciality.Commands;

public class CreateDoctorCommand : ICreateDoctorCommand
{
    private readonly IDataBaseService _dataBaseService;
    private readonly IMapper _mapper;

    public CreateDoctorCommand(IDataBaseService dataBaseService, IMapper mapper)
    {
        _dataBaseService = dataBaseService;
        _mapper = mapper;
    }

    public async Task<CreateDoctorModel> Execute(CreateDoctorModel model)
    {
        model.CreateAt = DateTime.UtcNow;
        var entity = _mapper.Map<DoctorEntity>(model);
        _dataBaseService.Doctors.Add(entity);

        await _dataBaseService.SaveAsync();

        return model;
    }
}