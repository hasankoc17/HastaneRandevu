using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevu.Models
{
    public class LoginViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
