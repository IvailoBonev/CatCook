using Microsoft.AspNetCore.Mvc;

namespace CatCook.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
