using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Domain.Entities
{
    public class Entrada
    {
        public int Id { get; set; }
        public int CondominioId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataEntrada { get; set; }
        public string TipoPagamento { get; set; }
        public string Status { get; set; }
        public string Categoria { get; set; }
        public DateTime DataPagamento { get; set; }
        public string PosicaoBoleto { get; set; }
        public decimal ValorRecebido { get; set; }
        public string Observacao { get; set; }
        public int MoradorId { get; set; }
    }
}
