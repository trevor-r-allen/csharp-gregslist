using Microsoft.AspNetCore.Mvc;

namespace csharp_gregslist.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class JobsController
  {
    [HttpGet]

    [HttpGet("{jobId}")]

    [HttpPost]

    [HttpPut("{jobId}")]

    [HttpDelete("{jobId}")]

  }
}