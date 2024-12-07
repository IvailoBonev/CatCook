using CatCook.Core.Contracts;
using CatCook.Core.Models.Recipe;
using CatCook.Core.Models.Tip;
using CatCook.Core.Services;
using CatCook.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CatCook.Controllers
{
    [Authorize]
    public class TipController : Controller
    {
        private readonly ILogger<TipController> _logger;
        private readonly ITipService tipService;

        public TipController(ITipService _tipService,
            ILogger<TipController> logger)
        {
            _logger = logger;
            tipService = _tipService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await tipService.AllRecipesOrdered();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new TipModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TipModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.UserId = User.Id();
            model.DateAdded = DateTime.Now;

            int id = await tipService.Create(model);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if ((await tipService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var model = await tipService.TipDetailsById(id);
            ViewBag.UserId = User.Id();

            return View(model);
        }
    }
}
