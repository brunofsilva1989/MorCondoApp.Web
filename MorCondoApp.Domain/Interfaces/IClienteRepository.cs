using MorCondoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> ListarClientesAsync();
        Task<Cliente> ObterClientePorIdAsync(int id);
        Task InserirAsync(Cliente cliente);
        Task AtualizarAsync(Cliente cliente);
        Task RemoverAsync(int id);
    }
}
