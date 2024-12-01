using CatCook.Core.Contracts;
using CatCook.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using static CatCook.Extensions.ClaimsPrincipalExtension;

namespace CatCook.Controllers
{
    [Authorize]
    public class RecipeController : Controller
    {
        private readonly ILogger<RecipeController> _logger;
        private readonly IRecipeService recipeService;

        public RecipeController(
            ILogger<RecipeController> logger,
            IRecipeService _recipeService)
        {
            _logger = logger;
            recipeService = _recipeService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await recipeService.AllRecipesOrdered();

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id, string information)
        {
            //TODO
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new RecipeModel()
            {
                RecipeCategories = await recipeService.AllCategories(),
                RecipeDifficulties = await recipeService.AllDifficulties()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(RecipeModel model)
        {
            if ((await recipeService.CategoryExists(model.CategoryId)) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Категорията не съществува");
            }

            if ((await recipeService.DifficultyExists(model.DifficultyId)) == false)
            {
                ModelState.AddModelError(nameof(model.DifficultyId), "Тази трудност не съществува");
            }

            if (!ModelState.IsValid)
            {
                model.RecipeCategories = await recipeService.AllCategories();
                model.RecipeDifficulties = await recipeService.AllDifficulties();

                return View(model);
            }

            model.UserId = User.Id();
            int id = await recipeService.Create(model);
            return RedirectToAction(nameof(All));
        }
    }
}
