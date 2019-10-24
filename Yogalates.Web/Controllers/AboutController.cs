using Microsoft.AspNetCore.Mvc;
using Yogalates.Services.Contracts;

namespace Yogalates.Web.Controllers
{
    public class AboutController : BaseController
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult About()
        {
            var about = _aboutService.GetAll();

            return View("About", about);
        }
    }
}