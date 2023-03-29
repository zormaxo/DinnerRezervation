using Microsoft.AspNetCore.Mvc;

namespace OutDinner.Api.Controllers;

[Route("[controller]")]

public class DinnersController : ApiController
{
    [HttpGet]
    public IActionResult Get() { return Ok(new[] { "Dinner 1", "Dinner 2" }); }
}