using CatCook.Core.Contracts;
using CatCook.Core.Models.Forum;
using CatCook.Core.Models.Recipe;
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
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if ((await forumService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var model = await forumService.ForumDetailsById(id);
            ViewBag.UserId = User.Id();

            return View(model);
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

            var forum = await forumService.ForumDetailsById(id);

            var model = new ForumModel()
            {
                Id = forum.Id,
                Title = forum.Title,
                Text = forum.Text,
                UserId = forum.UserId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ForumModel model)
        {
            if (id != model.Id)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await forumService.Exists(model.Id)) == false)
            {
                return View(model);
            }

            if ((await forumService.ForumWithUserId(model.Id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await forumService.Edit(model.Id, model);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if ((await forumService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await forumService.ForumWithUserId(id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var forum = await forumService.ForumDetailsById(id);
            var model = new ForumDetailsModel
            {
                Id = forum.Id,
                Title = forum.Title,
                DateAdded = forum.DateAdded
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, ForumDetailsModel model)
        {
            if ((await forumService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await forumService.ForumWithUserId(id, User.Id())) == false)
            {
                return RedirectToAction(nameof(All));
            }

            await forumService.Delete(id);

            return RedirectToAction(nameof(All));
        }
    }
}
