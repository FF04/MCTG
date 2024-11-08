namespace MCTG.Controllers
{
    using MCTG.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetUserCards()
        {
            throw new NotImplementedException();
        }

        [HttpGet("/deck")]
        [Authorize]
        public IActionResult GetDeck([FromQuery] string format = "json")
        {
            throw new NotImplementedException();

        }

        [HttpPut("/deck")]
        [Authorize]
        public IActionResult ConfigureDeck([FromBody] List<Guid> cardIds)
        {
            throw new NotImplementedException();

        }
    }

}
