using CatCook.Areas.Admin.Models;
using CatCook.Controllers;
using CatCook.Core.Contracts;
using CatCook.Core.Services;
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
    }
}
