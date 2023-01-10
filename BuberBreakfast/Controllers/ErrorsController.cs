using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controller;

public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}