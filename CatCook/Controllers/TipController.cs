using CatCook.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CatCook.Controllers
{
    [Authorize]
    public class TipController : Controller
    {
        private readonly ILogger<TipController> _logger;

        public TipController(
            ILogger<TipController> logger)
        {
            _logger = logger;
        }

        public IActionResult All()
        {
            return View();
        }
    }
}
