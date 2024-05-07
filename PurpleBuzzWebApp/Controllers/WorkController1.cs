using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzWebApp.Controllers
{
    public class WorkController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
