using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Domain.Entities
{
    public class Condominio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroUnidades { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public DateTime CreadedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
