using System;
using Microsoft.AspNetCore.Mvc;

// Controllers/AirportController.cs
[ApiController]
[Route("api/[controller]")]
public class AirportController : ControllerBase
{
    private readonly AirportService _service;

    public AirportController(AirportService service)
    {
        _service = service;
    }

    [HttpGet("search")]
    public IActionResult Search([FromQuery] string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return BadRequest("Query parameter is required.");

        var results = _service.Search(query);
        return Ok(results);
    }
}
