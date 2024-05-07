using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzWebApp.Controllers
{
    public class ContactController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
