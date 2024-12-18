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
        private readonly IAccountService accountService;

        public AccountController(
            ILogger<AccountController> logger,
            IAccountService _accountService)
        {
            _logger = logger;
            accountService = _accountService;
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

        public async Task<IActionResult> Test()
        {

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AllTips(string id)
        {
            if ((await accountService.Exists(id)) == false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = await accountService.AccountDetailsById(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AllForums(string id)
        {
            if ((await accountService.Exists(id)) == false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = await accountService.AccountDetailsById(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AllComments(string id)
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
