using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CatCook.NewFolder
{
    public class SetTempDataModelStateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);

            var controller = filterContext.Controller as Controller;
            var modelState = controller?.ViewData.ModelState;
            if (modelState != null)
            {
                var listError = modelState.Where(x => x.Value.Errors.Any())
                    .ToDictionary(m => m.Key, m => m.Value.Errors
                    .Select(s => s.ErrorMessage)
                    .FirstOrDefault(s => s != null));
                controller.TempData["KEY HERE"] = JsonConvert.SerializeObject(listError);
            }
        }
    }
}
