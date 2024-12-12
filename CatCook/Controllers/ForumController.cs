using CatCook.Core.Contracts;
using CatCook.Core.Models.Forum;
using CatCook.Core.Models.Tip;
using CatCook.Core.Services;
using CatCook.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace CatCook.Controllers
{
    [Authorize]
    public class ForumController : Controller
    {
        private readonly ILogger<ForumController> _logger;
        private readonly IForumService forumService;

        public ForumController(
            ILogger<ForumController> logger,
            IForumService _forumService)
        {
            _logger = logger;
            forumService = _forumService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await forumService.AllForumsOrdered();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ForumModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ForumModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.UserId = User.Id();
            model.DateAdded = DateTime.Now;

            int id = await forumService.Create(model);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await forumService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await forumService.ForumWithUserId(id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var tip = await forumService.ForumDetailsById(id);

            var model = new TipModel()
            {
                Id = id,
                Title = tip.Title,
                Description = tip.Description,
                UserId = tip.UserId
            };

            return View(model);
        }
    }
}
