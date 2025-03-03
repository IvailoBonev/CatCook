using CatCook.Core.Contracts;
using CatCook.Core.Models.Comment;
using CatCook.Core.Models.Tip;
using CatCook.Core.Services;
using CatCook.Extensions;
using CatCook.NewFolder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using static CatCook.Infrastructure.Common.Constants;

namespace CatCook.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        private readonly ILogger<CommentController> _logger;
        private readonly ICommentService commentService;

        public CommentController(
            ILogger<CommentController> logger,
            ICommentService _commentService)
        {
            _logger = logger;
            commentService = _commentService;
        }

        [HttpGet]
        public async Task<IActionResult> All(string userId)
        {
            var model = await commentService.AllCommentsOrdered(userId);

            return View(model);
        }

        [SetTempDataModelState]
        [HttpPost]
        public async Task<IActionResult> Add(CommentModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Details", "Forum", new { id = model.ForumId });
            }

            model.DateAdded = DateTime.Now;

            int id = await commentService.Create(model);

            return RedirectToAction("Details", "Forum", new { id = model.ForumId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await commentService.Exists(id)) == false)
            {
                return RedirectToAction("All", "Forum");
            }

            if ((await commentService.CommentWithUserId(id, User.Id(), User.IsInRole("Admin"))) == false)
            {
                return RedirectToAction("All", "Forum");
            }

            var comment = await commentService.CommentDetailsById(id);

            var model = new CommentModel()
            {
                Id = id,
                Title = comment.Title,
                Text = comment.Text,
                UserId = comment.UserId,
                ForumId = comment.ForumId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CommentModel model)
        {
            if (id != model.Id)
            {
                return RedirectToAction("All", "Forum");
            }

            if ((await commentService.Exists(model.Id)) == false)
            {
                return RedirectToAction("All", "Forum");
            }

            if ((await commentService.CommentWithUserId(model.Id, User.Id(), User.IsInRole("Admin"))) == false)
            {
                return RedirectToAction("All", "Forum");
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await commentService.Edit(model.Id, model);

            return RedirectToAction("Details", "Forum", new { id = model.ForumId });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if ((await commentService.Exists(id)) == false)
            {
                return RedirectToAction("All", "Forum");
            }

            if ((await commentService.CommentWithUserId(id, User.Id(), User.IsInRole("Admin"))) == false)
            {
                return RedirectToAction("All", "Forum");
            }

            var comment = await commentService.CommentDetailsById(id);
            var model = new CommentViewModel
            {
                Id = comment.Id,
                Title = comment.Title,
                DateAdded = comment.DateAdded,
                ForumId = comment.ForumId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, CommentViewModel model)
        {
            if ((await commentService.Exists(id)) == false)
            {
                return RedirectToAction("All", "Forum");
            }

            if ((await commentService.CommentWithUserId(id, User.Id(), User.IsInRole("Admin"))) == false)
            {
                return RedirectToAction("All", "Forum");
            }

            await commentService.Delete(id);

            return RedirectToAction("Details", "Forum", new { id = model.ForumId });
        }
    }
}
