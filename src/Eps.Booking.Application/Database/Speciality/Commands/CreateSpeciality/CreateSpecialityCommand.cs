using AutoMapper;
using Eps.Booking.Domain.Entities;

namespace Eps.Booking.Application.DataBase.Speciality.Commands;

public class CreateSpecialityCommand : ICreateSpecialityCommand
{
    private readonly IDataBaseService _databaseService;
    private readonly IMapper _mapper;


    public CreateSpecialityCommand(IDataBaseService dataBaseService, IMapper mapper)
    {
        _databaseService = dataBaseService;
        _mapper = mapper;
    }

    public async Task<SpecialityEntity> Execute(CreateSpecialityModel model)
    {
        var entity = _mapper.Map<SpecialityEntity>(model);

        await _databaseService.Specialities.AddAsync(entity);
        await _databaseService.SaveAsync();

        return entity;
    }
}