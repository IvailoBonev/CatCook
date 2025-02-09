using CatCook.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CatCook.Controllers
{
    public class ChatController : Controller
    {
        private readonly ILogger<ChatController> _logger;

        public ChatController(
            ILogger<ChatController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
