using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yogalates.Services.Contracts;

namespace Yogalates.Web.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private readonly IBlogService _contact;

        public ContactViewComponent(IBlogService contact)
        {
            _contact = contact;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var model = await _contact.GetContact;
            return View(/*model*/);
        }
    }
}
