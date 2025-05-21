using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Domain.Entities
{
    public class Saida
    {
        public int Id { get; set; }
        public int CondominioId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataSaida { get; set; }
        public string TipoPagamento { get; set; }
        public string Status { get; set; }
        public string Categoria { get; set; }
        public string Observacao { get; set; }                        
        public int MoradorId { get; set; }
    }
}
