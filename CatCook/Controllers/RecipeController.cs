﻿using CatCook.Core.Contracts;
using CatCook.Core.Models.Recipe;
using CatCook.Models;
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
        public async Task<IActionResult> All([FromQuery]AllRecipesQueryModel query)
        {
            var result = await recipeService.AllRecipes(
                User.Id(), User.IsInRole("Administrator"),
                query.Category,
                query.Difficulty,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllRecipesQueryModel.RecipesPerPage);

            query.TotalRecipesCount = result.TotalRecipesCount;
            query.Categories = await recipeService.AllCategoriesNames();
            query.Difficulties = await recipeService.AllDifficultiesNames();
            query.Recipes = result.Recipes;

            return View(query);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if ((await recipeService.Exists(id, User.Id(), User.IsInRole("Admin"))) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var model = await recipeService.RecipeDetailsById(id, User.Id(), User.IsInRole("Admin"));
            ViewBag.UserId = User.Id();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new RecipeModel()
            {
                RecipeCategories = await recipeService.AllCategories(),
                RecipeDifficulties = await recipeService.AllDifficulties(),
                UserId = User.Id()
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

            return RedirectToAction(nameof(Details), new { id = id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await recipeService.Exists(id, User.Id(), User.IsInRole("Admin"))) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await recipeService.RecipeWithUserId(id, User.Id(), User.IsInRole("Admin"))) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var recipe = await recipeService.RecipeDetailsById(id, User.Id(), User.IsInRole("Admin"));

            var model = new RecipeModel()
            {
                Id = id,
                CategoryId = recipe.CategoryId,
                DifficultyId = recipe.DifficultyId,
                Name = recipe.Name,
                UserId = User.Id(),
                ImageUrl = recipe.ImageUrl,
                IsPrivate = recipe.IsPrivate,
                TimeForCooking = recipe.TimeForCooking,
                TimeForPreparation = recipe.TimeForPreparation,
                Description = recipe.Description,
                PortionsCount = recipe.PortionsCount,
                Rating = double.Parse(recipe.Rating)
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

            if ((await recipeService.Exists(model.Id, User.Id(), User.IsInRole("Admin"))) == false)
            {
                model.RecipeCategories = await recipeService.AllCategories();
                model.RecipeDifficulties = await recipeService.AllDifficulties();

                return View(model);
            }

            if ((await recipeService.RecipeWithUserId(model.Id, User.Id(), User.IsInRole("Admin"))) == false)
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

            return RedirectToAction(nameof(Details), new { id = model.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if ((await recipeService.Exists(id, User.Id(), User.IsInRole("Admin"))) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await recipeService.RecipeWithUserId(id, User.Id(), User.IsInRole("Admin"))) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var recipe = await recipeService.RecipeDetailsById(id, User.Id(), User.IsInRole("Admin"));
            var model = new RecipeDetailsModel
            {
                Id = recipe.Id,
                Name = recipe.Name,
                DateAdded = recipe.DateAdded
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, RecipeDetailsModel model)
        {
            if ((await recipeService.Exists(id, User.Id(), User.IsInRole("Admin"))) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await recipeService.RecipeWithUserId(id, User.Id(), User.IsInRole("Admin"))) == false)
            {
                return RedirectToAction(nameof(All));
            }

            await recipeService.Delete(id);

            return RedirectToAction(nameof(All));
        }
    }
}
