using Microsoft.AspNetCore.Mvc;

namespace ACCTNGSYS.Areas.Admin.Controllers;

[Area("Admin")]
[Route("admin/role-menu")]
public class RoleMenuController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
}