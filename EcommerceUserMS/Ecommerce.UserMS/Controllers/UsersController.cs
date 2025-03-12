using Ecommerce.UserMS.Application.Service.Abstraction;
using Ecommerce.UserMS.Domain.Model.ResponseDto;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.UserMS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUsersService _usersService;

    public UsersController(IUsersService usersService)
    {
        _usersService = usersService;
    }


    //GET /api/Users/{userID}
    [HttpGet("{userID}")]
    public async Task<IActionResult> GetUserByUserID(Guid userID)
    {
        //await Task.Delay(10000);
        //throw new NotImplementedException();

        if (userID == Guid.Empty)
        {
            return BadRequest("Invalid User ID");
        }

        UserDTO? response = await _usersService.GetUserByUserID(userID);

        if (response == null)
        {
            return NotFound(response);
        }

        return Ok(response);
    }


    //GET /api/Users
    [HttpGet()]
    public async Task<IActionResult> GetUsers()
    {

        List<UserDTO> response = await _usersService.GetUsers();

        if (response == null)
        {
            return NotFound(response);
        }

        return Ok(response);
    }
}

