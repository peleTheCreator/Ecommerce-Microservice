using Ecommerce.UserMS.Application.Service.Abstraction;
using Ecommerce.UserMS.Domain.Model.RequestDto;
using Ecommerce.UserMS.Domain.Model.ResponseDto;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.UserMS.API.Controllers
{
    [Route("api/[controller]")] //api/auth
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public AuthController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        //Endpoint for user registration use case
        [HttpPost("register")] //POST api/auth/register
        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            //Check for invalid registerRequest
            if (registerRequest == null)
            {
                return BadRequest("Invalid registration data");
            }

            //Call the UsersService to handle registration
            AuthenticationResponse? authenticationResponse = await _usersService.Register(registerRequest);

            if (authenticationResponse == null || authenticationResponse.Success == false)
            {
                return BadRequest(authenticationResponse);
            }

            return Ok(authenticationResponse);
        }


        //Endpoint for user login use case
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            //Check for invalid LoginRequest
            if (loginRequest == null)
            {
                return BadRequest("Invalid login data");
            }

            AuthenticationResponse? authenticationResponse = await _usersService.Login(loginRequest);

            if (authenticationResponse == null || authenticationResponse.Success == false)
            {
                return Unauthorized(authenticationResponse);
            }

            return Ok(authenticationResponse);
        }
    }
}
