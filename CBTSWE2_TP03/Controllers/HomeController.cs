using Microsoft.AspNetCore.Mvc;

namespace CBTSWE2_TP03.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}