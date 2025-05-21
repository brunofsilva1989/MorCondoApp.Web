using MorCondoApp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Infrastructure.Services
{
    public interface IClienteService
    {
        Task<List<ClienteDto>> ListarClientesAsync();
        Task<ClienteDto> ObterClientePorIdAsync(int id);
        Task InserirClienteAsync(ClienteDto cliente);
        Task AtualizarClienteAsync(ClienteDto cliente);
        Task RemoverClienteAsync(int id);
    }
}
