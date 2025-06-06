using MorCondoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> ObterPorEmailESenhaAsync(string email, string senha);
    }
}
