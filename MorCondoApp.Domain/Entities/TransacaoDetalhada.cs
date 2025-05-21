using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Domain.Entities
{
    public class TransacaoDetalhada
    {
        public int Id { get; set; }
        public TipoTransacao TipoTransacao { get; set; } 
        public int CondominioId { get; set; }
        public int MoradorId { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal ValorReceber { get; set; }
        public DateTime DataTransacao { get; set; }
        public string AtividadesAdmin { get; set; }
        public StatusPagamento StatusPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal CaixaMesAnterior { get; set; }
    }

    public enum TipoTransacao
    {
        Entrada,
        Saida
    }

    public enum StatusPagamento
    {
        Pendente,
        Pago,
        Parcial,
        Cancelado
    }
}
