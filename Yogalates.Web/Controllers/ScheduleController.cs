using Microsoft.AspNetCore.Mvc;

namespace Yogalates.Web.Controllers
{
    public class ScheduleController : BaseController
    {
        public IActionResult Schedule()
        {
            return View();
        }
    }
}