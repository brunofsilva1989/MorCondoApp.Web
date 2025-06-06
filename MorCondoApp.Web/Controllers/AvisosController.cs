using Microsoft.AspNetCore.Mvc;

namespace MorCondoApp.Web.Controllers
{
    public class AvisosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
