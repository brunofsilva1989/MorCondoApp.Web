using Microsoft.AspNetCore.Mvc;

namespace MorCondoApp.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
