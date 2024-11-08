using MCTG.Models.Card;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MCTG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagesController
    {
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult CreatePackage([FromBody] List<CardModel> cards)
        {
        }
    }

    [Route("api/transactions/packages")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        [HttpPost]
        [Authorize]
        public IActionResult AcquirePackage()
        {
        }
    }
}
