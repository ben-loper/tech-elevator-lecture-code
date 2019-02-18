using Microsoft.AspNetCore.Mvc;
using VendingService;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VndrMVC.Controllers
{
    public class BaseController : Controller
    {
        IVendingMachine _vm = null;

        public BaseController(IVendingMachine vm)
        {
            _vm = vm;
        }

        public ActionResult GetAuthenticatedView(string viewName, object model = null)
        {
            ActionResult result = null;
            if (_vm.IsAuthenticated)
            {
                result = View(viewName, model);
            }
            else
            {
                result = RedirectToAction("Login", "User");
            }
            return result;
        }

        public JsonResult GetAuthenticatedJson(JsonResult json, bool hasPermission)
        {
            JsonResult result = null;
            if (!hasPermission && _vm.IsAuthenticated)
            {
                result = Json(new { error = "User is not permitted to access this data." });
            }
            else if (_vm.IsAuthenticated)
            {
                result = json;
            }
            else
            {
                result = Json(new { error = "User is not authenticated." });
            }
            return result;
        }
    }
}
