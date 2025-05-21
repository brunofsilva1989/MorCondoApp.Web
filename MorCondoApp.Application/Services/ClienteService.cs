using MorCondoApp.Application.DTOs;
using MorCondoApp.Domain.Interfaces;
using MorCondoApp.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task AtualizarClienteAsync(ClienteDto cliente)
        {
            throw new NotImplementedException();
        }

        public Task InserirClienteAsync(ClienteDto cliente)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ClienteDto>> ListarClientesAsync()
        {
            var lista = await _clienteRepository.ListarClientesAsync();
            return lista.Select(l => new ClienteDto
            {
                Id = l.Id,
                Nome = l.Nome,
                Email = l.Email,
                Telefone = l.Telefone,
                CpfCnpj = l.CpfCnpj,
                Unidade = l.Unidade,
                DataCadastro = l.CreatedAt,                
            }).ToList();
        }

        public Task<ClienteDto> ObterClientePorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoverClienteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }

}
