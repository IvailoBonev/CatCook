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
            var model = await tipService.AllTipsOrdered();

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
            return RedirectToAction(nameof(Details), new { id = id });
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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await tipService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await tipService.TipWithUserId(id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var tip = await tipService.TipDetailsById(id);

            var model = new TipModel()
            {
                Id = id,
                Title = tip.Title,
                Description = tip.Description,
                UserId = tip.UserId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, TipModel model)
        {
            if (id != model.Id)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await tipService.Exists(model.Id)) == false)
            {
                return View(model);
            }

            if ((await tipService.TipWithUserId(model.Id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await tipService.Edit(model.Id, model);

            return RedirectToAction(nameof(Details), new { id = model.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if ((await tipService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await tipService.TipWithUserId(id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var tip = await tipService.TipDetailsById(id);
            var model = new TipDetailsModel
            {
                Id = tip.Id,
                Title = tip.Title,
                DateAdded = tip.DateAdded
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, RecipeDetailsModel model)
        {
            if ((await tipService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await tipService.TipWithUserId(id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            await tipService.Delete(id);

            return RedirectToAction(nameof(All));
        }
    }
}
