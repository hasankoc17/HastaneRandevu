using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevu.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
