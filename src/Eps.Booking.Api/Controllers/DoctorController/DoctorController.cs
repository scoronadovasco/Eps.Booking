using Eps.Booking.Application.DataBase.Doctor.Commands;
using Eps.Booking.Application.DataBase.Doctor.Querys;
using Eps.Booking.Application.Exceptions;
using Eps.Booking.Application.Features;
using Microsoft.AspNetCore.Mvc;

namespace Eps.Booking.Api.Controllers;

[Route("api/v1/doctor/")]
[ApiController]
[TypeFilter(typeof(ExceptionManager))]
public class DoctorController : ControllerBase
{
    [HttpPost("create")]
    public async Task<IActionResult> CreateDoctor([FromBody] CreateDoctorModel model,
    [FromServices] ICreateDoctorCommand createDoctorCommand)
    {
        var data = await createDoctorCommand.Execute(model);

        return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data, "Creado Exitosamente"));
    }

    [HttpPost("update")]

    public async Task<IActionResult> UpdateDoctor([FromBody] UpdateDoctorModel model,
     [FromServices] IUpdateDoctorCommand updateDoctorCommand)
    {
        var data = await updateDoctorCommand.Execute(model);

        return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK,data,"Actualizado con exito"));
    }

    [HttpDelete("delete/{id}")]
     public async Task<IActionResult> UpdateDoctor(Guid id,
     [FromServices] IDeleteDoctorCommand updateDoctorCommand)
    {
        var data = await updateDoctorCommand.Execute(id);

        return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK,data,"Actualizado con exito"));
    }


    [HttpGet("getalldoctors")]
    public async Task<IActionResult> GetAllUsers([FromServices] IGetAllDoctorsQuery getAllUsersQuery)
    {
        var users = await getAllUsersQuery.Execute();

        return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, users, "exitoso"));
    }

    [HttpGet("getdoctorbyid/{id}")]
    public async Task<IActionResult> GetUserById([FromServices] IGetDoctorByIdQuery getUserByIdQuery , Guid id)
    {
        var users = await getUserByIdQuery.Execute(id);
        return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, users, "exitoso"));
    }
}