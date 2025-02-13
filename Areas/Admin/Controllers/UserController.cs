using Microsoft.AspNetCore.Mvc;

namespace ACCTNGSYS.Areas.Admin.Controllers;

[Area("Admin")]
[Route("admin/user")]
public class UserController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
}