using Microsoft.AspNetCore.Mvc;

namespace Yogalates.Web.Controllers
{
    public class EventsController : BaseController
    {
        public IActionResult Events()
        {
            return View();
        }
    }
}