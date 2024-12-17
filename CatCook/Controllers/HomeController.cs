using CatCook.Core.Contracts;
using CatCook.Core.Models.Recipe;
using CatCook.Core.Models.Tip;
using CatCook.Extensions;
using CatCook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CatCook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRecipeService recipeService;
        private readonly ITipService tipService;

        public HomeController(
            ILogger<HomeController> logger,
            IRecipeService _recipeService,
            ITipService _tipService)
        {
            _logger = logger;
            recipeService = _recipeService;
            tipService = _tipService;
        }

        public async Task<IActionResult> Index()
        {
            var item1 = await recipeService.LastFourRecipes(User.Id(), User.IsInRole("Administrator"));
            var item2 = await tipService.LastFourTips();
            var model = new Tuple<ICollection<RecipeHomeModel>, ICollection<TipHomeModel>>(item1, item2);

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
