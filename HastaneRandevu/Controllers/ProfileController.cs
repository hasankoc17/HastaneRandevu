using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevu.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
