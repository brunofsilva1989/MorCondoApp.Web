using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Domain.Entities
{
    public class Boleto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string PaymentId { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime DataVencimento { get; set; }
        public string BoletoUrl { get; set; }
        public string SeuNumero { get; set; }

    }
}
