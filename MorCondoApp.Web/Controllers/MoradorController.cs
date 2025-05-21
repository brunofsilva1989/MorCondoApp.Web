using Microsoft.AspNetCore.Mvc;

namespace MorCondoApp.Web.Controllers
{
    public class MoradorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
