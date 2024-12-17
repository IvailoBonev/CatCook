
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Abstractions;

namespace CatCook.Controllers
{
    [Route("error")]
    public class ErrorController : Controller
    {
        [Route("500")]
        public IActionResult AppError()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            string originalPath = "unknown";
            string errorMessage = "unknown";

            if (HttpContext.Items.ContainsKey("originalPath"))
            {
                originalPath = HttpContext.Items["originalPath"] as string;
                errorMessage = exceptionHandlerPathFeature.Error.Message;
            }

            return View();
        }

        [Route("404")]
        public IActionResult PageNotFound()
        {
            string originalPath = "unknown";
            if (HttpContext.Items.ContainsKey("originalPath"))
            {
                originalPath = HttpContext.Items["originalPath"] as string;
            }
            return View();
        }
    }
}
