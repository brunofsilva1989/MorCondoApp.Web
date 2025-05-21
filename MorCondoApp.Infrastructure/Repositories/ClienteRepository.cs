using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using MorCondoApp.Domain.Entities;
using MorCondoApp.Domain.Interfaces;

namespace MorCondoApp.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        const string PROC_LISTAR_CLIENTES = "sp_ListarClientes";

        private readonly string _connectionString;
        public ClienteRepository(IConfiguration configuration)
        {            
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<Cliente>> ListarClientesAsync()
        {
            var lista = new List<Cliente>();
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(PROC_LISTAR_CLIENTES, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            await conn.OpenAsync();
            var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                lista.Add(new Cliente
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nome = reader["Nome"].ToString(),
                    Email = reader["Email"].ToString(),
                    Telefone = reader["Telefone"].ToString(),
                    CpfCnpj = reader["Cpf_Cnpj"].ToString(),
                    Endereco = reader["Endereco"].ToString(),
                    Numero = reader["Numero"].ToString(),
                    Complemento = reader["Complemento"].ToString(),
                    Bairro = reader["Bairro"].ToString(),
                    Cidade = reader["Cidade"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    Cep = reader["Cep"].ToString(),
                    CreatedAt = Convert.ToDateTime(reader["Created_At"]),
                    UpdatedAt = Convert.ToDateTime(reader["Updated_At"]),
                    CondominioId = Convert.ToInt32(reader["Condominio_Id"]),
                    ProprietarioId = Convert.ToInt32(reader["Proprietario_Id"]),
                    Unidade = reader["Unidade"].ToString()
                });                
                
            }
            return lista;
        }

        public Task InserirAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }
       
        public Task<Cliente> ObterClientePorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task RemoverAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
