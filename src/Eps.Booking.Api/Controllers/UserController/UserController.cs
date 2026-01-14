using Eps.Booking.Application.DataBase.User.Commands;
using Eps.Booking.Application.DataBase.User.Querys;
using Eps.Booking.Application.Exceptions;
using Eps.Booking.Application.Features;
using Microsoft.AspNetCore.Mvc;

namespace Eps.Booking.Api.Controllers;

[Route("api/v1/user/")]
[ApiController]
[TypeFilter(typeof(ExceptionManager))]
public class UserController : ControllerBase
{
    [HttpPost("create")]
    public async Task<IActionResult> Create(
        [FromBody] CreateUserModel model,
        [FromServices] ICreateUserCommand createUserCommand)
    {
        var data = await createUserCommand.Execute(model);
        return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data, "creado con exito"));
    }

    [HttpPost("update")]
    public async Task<IActionResult> Update(
        [FromBody] UpdateUserModel model,
        [FromServices] IUpdateUserCommand updateUserCommand)
    {
        var data = await updateUserCommand.Execute(model);
        return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data, "creado con exito"));
    }

    [HttpPut("updatepassword")]
    public async Task<IActionResult> UpdatePassword([FromBody] UpdateUserPasswordModel model,
    [FromServices] IUpdateUserPasswordCommand updateUserPasswordCommand)
    {
        var data =await updateUserPasswordCommand.Execute(model);
        return StatusCode(StatusCodes.Status200OK,ResponseApiService.Response(StatusCodes.Status200OK,data,"actualizado correctamente"));
    }

    [HttpDelete("delete/{id}")]

    public async Task<IActionResult> Delete(Guid id, [FromServices] IDeleteUserCommand deleteUserCommand)
    {
        var data = await deleteUserCommand.Execute(id);

        return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data, "eliminado correctamente"));
    }

    [HttpGet("getallusers")]
    public async Task<IActionResult> GetAllUsers([FromServices] IGetAllUsersQuery getAllUsersQuery)
    {
        var users = await getAllUsersQuery.Execute();

        return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, users, "exitoso"));
    }

    [HttpGet("getuserbyid/{id}")]
    public async Task<IActionResult> GetUserById([FromServices] IGetUserByIdQuery getUserByIdQuery , Guid id)
    {
        var users = await getUserByIdQuery.Execute(id);
        return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, users, "exitoso"));
    }
}