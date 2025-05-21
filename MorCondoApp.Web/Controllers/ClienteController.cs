using Microsoft.AspNetCore.Mvc;
using MorCondoApp.Infrastructure.Services;
using System.Runtime.CompilerServices;

namespace MorCondoApp.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }


        public async Task<IActionResult> Index()
        {
            var clientes = await _clienteService.ListarClientesAsync();
            return View(clientes);
        }
    }
}
