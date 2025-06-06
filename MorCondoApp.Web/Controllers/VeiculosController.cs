using Microsoft.AspNetCore.Mvc;

namespace MorCondoApp.Web.Controllers
{
    public class VeiculosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
