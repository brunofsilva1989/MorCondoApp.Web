using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Domain.Entities
{
    public class ManutencaoPredial
    {
        public int Id { get; set; }
        public DateTime DataManutencao { get; set; }
        public string Responsavel { get; set; }
        public string Descricao { get; set; }
        public Decimal Custo { get; set; }
        public string StatusManutencao { get; set; } = "Pendente";
        public int CondominioId { get; set; }
    }
}
