using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MorCondoApp.Domain.Interfaces;
using System.Security.Claims;

namespace MorCondoApp.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index() => View();

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("MorCondoAuth");
            return RedirectToAction("Login");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(string email, string senha)
        {

            try
            {
                var usuario = await _usuarioRepository.ObterPorEmailESenhaAsync(email, senha);

                if (usuario == null)
                {
                    return Json(new { success = false, redirectUrl = "Usuário ou senha inválidos." });
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario.Nome),
                    new Claim(ClaimTypes.Email, usuario.Email),
                };

                var claimsIdentity = new ClaimsIdentity(claims, "MorCondoAuth");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                await HttpContext.SignInAsync("MorCondoAuth", claimsPrincipal);

                return Json(new { success = true, redirectUrl = "/Home/Index" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"X Erro no login: {ex}");
                return Json(new { success = false, message = "Erro interno " + ex.Message });
            }                                   
        }

        [AllowAnonymous]
        public IActionResult AccessDenied() => View();
    }
}
