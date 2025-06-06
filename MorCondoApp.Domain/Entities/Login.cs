namespace MorCondoApp.Domain.Entities
{
    public class Login
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; }
        public bool Ativo { get; set; } = true;
        public string TipoUsuario { get; set; } // Ex: "Administrador", "Morador", "Funcionário"
        public string Email { get; set; } // Adicionando email para login
        public string TipoSenha { get; set; } // Ex: "Texto", "Hash", "Criptografada"

    }
}
