using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
