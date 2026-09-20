using Microsoft.AspNetCore.Mvc;

namespace ForgeCI.Api.Controllers;

[ApiController]
[Route("api/builds")]
public class BuildsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetBuilds()
    {
        return Ok(new[]
        {
            new
            {
                id = 1,
                repository = "example/repo",
                branch = "main",
                status = "QUEUED"
            }
        });
    }
}