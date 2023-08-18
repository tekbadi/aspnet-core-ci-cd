using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_ci_cd.Controllers;

[ApiController]
[Route("/test")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "techbuddy";
    }
}
