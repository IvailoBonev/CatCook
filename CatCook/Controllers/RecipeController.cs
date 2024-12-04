using CatCook.Core.Contracts;
using CatCook.Core.Models.Recipe;
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
            var model = await recipeService.AllRecipesOrdered(User.Id());

            return View(model);
        }

        public async Task<IActionResult> Test()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if ((await recipeService.Exists(id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var model = await recipeService.RecipeDetailsById(id, User.Id());

            return View(model);
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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await recipeService.Exists(id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await recipeService.RecipeWithUserId(id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var recipe = await recipeService.RecipeDetailsById(id, User.Id());

            var model = new RecipeModel()
            {
                Id = id,
                CategoryId = recipe.CategoryId,
                DifficultyId = recipe.DifficultyId,
                Name = recipe.Name,
                UserId = User.Id(),
                ImageUrls = string.Join(Environment.NewLine, recipe.ImagesUrl),
                IsPrivate = recipe.IsPrivate,
                TimeForCooking = recipe.TimeForCooking,
                TimeForPreparation = recipe.TimeForPreparation,
                Description = recipe.Description,
                Products = string.Join(Environment.NewLine, recipe.Products),
                PortionsCount = recipe.PortionsCount
            };

            model.RecipeCategories = await recipeService.AllCategories();
            model.RecipeDifficulties = await recipeService.AllDifficulties();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, RecipeModel model)
        {
            if (id != model.Id)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await recipeService.Exists(model.Id, User.Id())) == false)
            {
                model.RecipeCategories = await recipeService.AllCategories();
                model.RecipeDifficulties = await recipeService.AllDifficulties();

                return View(model);
            }

            if ((await recipeService.RecipeWithUserId(model.Id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await recipeService.CategoryExists(model.CategoryId)) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
                model.RecipeCategories = await recipeService.AllCategories();
                model.RecipeDifficulties = await recipeService.AllDifficulties();

                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                model.RecipeCategories = await recipeService.AllCategories();
                model.RecipeDifficulties = await recipeService.AllDifficulties();

                return View(model);
            }

            await recipeService.Edit(model.Id, model);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if ((await recipeService.Exists(id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await recipeService.RecipeWithUserId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var house = await recipeService.RecipeDetailsById(id, User.Id());
            var model = new RecipeDetailsModel
            {
                Name = house.Name,
                DateAdded = house.DateAdded
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, RecipeDetailsModel model)
        {
            if ((await recipeService.Exists(id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await recipeService.RecipeWithUserId(id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            await recipeService.Delete(id);

            return RedirectToAction(nameof(All));
        }
    }
}
