using MCTG.Models;
using MCTG.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCTG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (user is null)
                return Unauthorized();
            if (string.IsNullOrWhiteSpace(user.Email))
                return Unauthorized();
            if (string.IsNullOrWhiteSpace(user.Password))
                return Unauthorized();

            _service.RegisterUser(user);
            return Ok();
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login([FromBody] User user)
        {
            if (user is null)
                return Unauthorized();
            if (string.IsNullOrWhiteSpace(user.Email))
                return Unauthorized();
            if (string.IsNullOrWhiteSpace(user.Password))
                return Unauthorized();

            _service.LoginUser(user);
            return Ok();
        }

    }
}
