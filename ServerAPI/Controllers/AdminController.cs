using Microsoft.AspNetCore.Mvc;

namespace ServerAPI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
