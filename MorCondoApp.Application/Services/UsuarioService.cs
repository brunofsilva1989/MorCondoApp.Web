using MorCondoApp.Domain.Entities;
using MorCondoApp.Domain.Interfaces;

namespace MorCondoApp.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<bool> AtivarUsuarioAsync(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AtualizarSenhaAsync(int usuarioId, string novaSenha)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AutenticarUsuarioAsync(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DesativarUsuarioAsync(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<string> RecuperarSenhaAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarUsuarioAsync(string email, string senha, string tipoUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidarTokenRecuperacaoSenhaAsync(string token)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> ObterPorEmailESenhaAsync(string email, string senha)
        {
            // Assuming the repository method returns a Task<bool>, update the repository interface if needed.
            return await _usuarioRepository.ObterPorEmailESenhaAsync(email, senha);
        }
    }
}
