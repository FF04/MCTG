using MCTG.Models;
using MCTG.Services;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
        public IActionResult Register([FromBody] UserCredentials credentials)
        {
            throw new NotImplementedException();

        }

        [HttpGet("{username}")]
        [Authorize]
        public IActionResult GetUser(string username)
        {
            throw new NotImplementedException();

        }

        [HttpPut("{username}")]
        [Authorize]
        public IActionResult UpdateUser(string username, [FromBody] UserData userData)
        {
            throw new NotImplementedException();

        }

        [HttpPost("/sessions")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] UserCredentials credentials)
        {
            throw new NotImplementedException();

        }


    }
}
