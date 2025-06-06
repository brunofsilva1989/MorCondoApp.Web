using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using MorCondoApp.Domain.Entities;
using MorCondoApp.Domain.Interfaces;

namespace MorCondoApp.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly string _connectionString = "DefaultConnection";
        public UsuarioRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        const string PROC_AUTENTICAR_USUARIO = "sp_AutenticarUsuario";

        /// <summary>
        /// Autentica de usuario com base no email e senha fornecidos.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public async Task<Usuario?> AutenticacaoAsync(string email, string senha)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(PROC_AUTENTICAR_USUARIO, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Senha", senha);

            await conn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                return new Usuario
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nome = reader["Nome"].ToString(),
                    Email = reader["Email"].ToString(),
                    SenhaHash = reader["Senha_Hash"].ToString(),
                    Tipo = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), reader["Tipo"].ToString()),
                    UsuarioId = reader["Usuario_Id"] == DBNull.Value ? 0 : (int)Convert.ToInt32(reader["Usuario_Id"]), 
                    CondominioId = reader["Condominio_Id"] == DBNull.Value ? 0 : (int)Convert.ToInt32(reader["Condominio_Id"]),
                    CreatedAt = Convert.ToDateTime(reader["Created_At"]),
                    UpdatedAt = Convert.ToDateTime(reader["Updated_At"]),
                    ClienteId = reader["Cliente_Id"] == DBNull.Value ? 0 : (int)Convert.ToInt32(reader["Condominio_Id"]),
                    Status = reader["Status"].ToString()
                };
            }
            return null;
        }

        public Task<Usuario> ObterPorEmailESenhaAsync(string email, string senha)
        {
            var usuario = AutenticacaoAsync(email, senha);
            if (usuario == null)
            {
                throw new Exception("Usuário ou senha inválidos.");
            }

            return usuario;

        }
    }
}
