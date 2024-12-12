using CatCook.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CatCook.Controllers
{
    public class ForumController : Controller
    {
        private readonly ILogger<RecipeController> _logger;

        public ForumController(
            ILogger<RecipeController> logger,
            IRecipeService _recipeService)
        {
            _logger = logger;
        }
        public IActionResult All()
        {
            return View();
        }
    }
}
