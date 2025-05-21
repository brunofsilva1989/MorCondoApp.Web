using Microsoft.AspNetCore.Mvc;

namespace MorCondoApp.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
