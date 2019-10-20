using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yogalates.Models;
using Yogalates.Services.Contracts;

namespace Yogalates.Web.Controllers
{
    public class BlogController : BaseController
    {
        private readonly IBlogService _blogService;
        private readonly UserManager<YogalatesUser> _currentUser;
        private readonly ILogger _logger;

        public BlogController(IBlogService blogService, UserManager<YogalatesUser> currentUser, ILogger<BlogController> logger)
        {
            _blogService = blogService;
            _currentUser = currentUser;
            _logger = logger;
        }

        public async Task<IActionResult> Blog()
        {
            var allArticles = await _blogService.GetAllArticles();
            return View("Blog", allArticles);
        }
    }
}