using CatCook.Core.Contracts;
using CatCook.Core.Models.Account;
using CatCook.Core.Models.Recipe;
using CatCook.Core.Services;
using CatCook.Extensions;
using CatCook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CatCook.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IRecipeService recipeService;
        private readonly IAccountService accountService;

        public AccountController(
            ILogger<AccountController> logger,
            IRecipeService _recipeService,
            IAccountService _accountService)
        {
            _logger = logger;
            accountService = _accountService;
            recipeService = _recipeService;
        }

        [HttpGet]
        public async Task<IActionResult> AllRecipes(string id)
        {
            if ((await accountService.Exists(id)) == false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = await accountService.AccountDetailsById(id);

            return View(model);
        }
    }
}
