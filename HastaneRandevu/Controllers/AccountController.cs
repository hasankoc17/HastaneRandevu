using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevu.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register() 
        
       {
            return View();
       }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Logout() 
        { 
            return View(); 
        }
    }
}
