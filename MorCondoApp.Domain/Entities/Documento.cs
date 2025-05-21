using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorCondoApp.Domain.Entities
{
    public class Documento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoDoc Tipo { get; set; }
        public string Caminho { get; set; }
        public DateTime DataUpload { get; set; } = DateTime.Now;
        public int CondominioId { get; set; }
        public int UsuarioId { get; set; }
    }

    public enum TipoDoc
    {
        Boleto,
        Balancete,
        Aviso        
    }
}
