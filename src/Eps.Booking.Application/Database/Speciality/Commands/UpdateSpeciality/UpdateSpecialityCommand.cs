using AutoMapper;
using Eps.Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eps.Booking.Application.DataBase.Speciality.Commands;

public class UpdateSpecialityCommand: IUpdateSpecialityCommand
{
    private readonly IDataBaseService _databaseService;
    private readonly IMapper _mapper;

    public UpdateSpecialityCommand(IDataBaseService dataBaseService, IMapper mapper)
    {
        _mapper = mapper;
        _databaseService = dataBaseService;
    }

    public async Task<UpdateSpecialityModel> Execute(UpdateSpecialityModel model)
    {
        var entity = _mapper.Map<SpecialityEntity>(model);

        _databaseService.Specialities.Update(entity);
        await _databaseService.SaveAsync();
        return model;
    }
}