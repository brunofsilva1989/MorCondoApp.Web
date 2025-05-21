using Microsoft.AspNetCore.Mvc;

namespace MorCondoApp.Web.Controllers
{
    public class CondominioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
