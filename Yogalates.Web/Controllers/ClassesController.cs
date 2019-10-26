using Microsoft.AspNetCore.Mvc;

namespace Yogalates.Web.Controllers
{
    public class ClassesController : BaseController
    {
        public IActionResult Classes()
        {
            return View();
        }
    }
}