using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CatCook.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/Admin/[controller]/[Action]/{id?}")]
    [Authorize(Policy = "RequireAdministratorRole")]
    public class BaseController : Controller
    {
    }
}
