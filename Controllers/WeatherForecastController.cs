using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_ci_cd.Controllers;

[ApiController]
[Route("/test")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        return "techbuddy";
    }
}
