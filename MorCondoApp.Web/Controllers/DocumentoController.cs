using Microsoft.AspNetCore.Mvc;

namespace MorCondoApp.Web.Controllers
{
    public class DocumentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
