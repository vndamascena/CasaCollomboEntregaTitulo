using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Entities
{
    public class Impressao
    {
        public int IdImpressao { get; set; }
        public int EntregaId { get; set; }
        public int? NumeroNota { get; set; }
        public string? NomeCliente { get; set; }
        public string? UsuarioId { get; set; }
        public DateTime DataTime { get; set; }
        public Entrega? Entrega { get; set; }
    }
}
