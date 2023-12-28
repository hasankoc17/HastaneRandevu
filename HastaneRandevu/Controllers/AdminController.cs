using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevu.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
