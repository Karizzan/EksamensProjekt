using Microsoft.AspNetCore.Mvc;

namespace ServerAPI.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
