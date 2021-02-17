using Microsoft.AspNetCore.Mvc;

namespace csharp_gregslist.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HousesController : ControllerBase
  {
    [HttpGet]

    [HttpGet("{houseId}")]

    [HttpPost]

    [HttpPut("{houseId}")]

    [HttpDelete("{houseId}")]

  }
}