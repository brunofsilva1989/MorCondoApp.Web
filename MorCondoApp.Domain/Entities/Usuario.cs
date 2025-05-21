using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public TipoUsuario Tipo { get; set; }
        public int UsuarioId { get; set; }
        public int CondomiioId { get; set; }
        public int ClienteId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public string Status { get; set; } = "Ativo";
    }

    public enum TipoUsuario
    {
        Admin,
        Usuario,
        Morador
    }

}
