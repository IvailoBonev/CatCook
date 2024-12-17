using CatCook.Areas.Admin.Models;
using CatCook.Controllers;
using CatCook.Core.Contracts;
using CatCook.Core.Models.Account;
using CatCook.Core.Models.Tip;
using CatCook.Core.Services;
using CatCook.Extensions;
using CatCook.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatCook.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IAccountService accountService;

        public AdminController(
            ILogger<AdminController> logger,
            IAccountService _accountService)
        {
            _logger = logger;
            accountService = _accountService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> AllAccounts([FromQuery]AllAccountsQueryModel query)
        {
            var result = await accountService.AllAccounts(
                query.SearchTerm,
                query.CurrentPage,
                AllAccountsQueryModel.AccountsPerPage);

            query.TotalAccountsCount = result.TotalAccountsCount;
            query.Accounts = result.Accounts;

            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteAccount(string id)
        {
            if ((await accountService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(AllAccounts));
            }

            var account = await accountService.AccountDetailsById(id);
            var model = new AccountDetailsModel
            {
                Id = account.Id,
                ProfileName = account.ProfileName,
                Email = account.Email
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAccount(string id, AccountDetailsModel model)
        {
            if ((await accountService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(AllAccounts));
            }

            await accountService.Delete(id);

            return RedirectToAction(nameof(AllAccounts));
        }
    }
}
