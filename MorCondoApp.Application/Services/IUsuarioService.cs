using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Application.Services
{
    public interface IUsuarioService
    {
        Task<bool> AutenticarUsuarioAsync(string email, string senha);
        Task<bool> RegistrarUsuarioAsync(string email, string senha, string tipoUsuario);
        Task<bool> AtualizarSenhaAsync(int usuarioId, string novaSenha);
        Task<bool> DesativarUsuarioAsync(int usuarioId);
        Task<bool> AtivarUsuarioAsync(int usuarioId);
        Task<string> RecuperarSenhaAsync(string email);
        Task<bool> ValidarTokenRecuperacaoSenhaAsync(string token);
    }
}
