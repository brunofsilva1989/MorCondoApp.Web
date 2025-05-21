using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Domain.Entities
{
    public class Morador
    {
        public int Id { get; set; }
        public string Nome { get; set; }        
        public int CondomiioId { get; set; }
        public string Unidade { get; set; }
        public string Observacao { get; set; }                
    }
}
