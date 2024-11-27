using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Entities
{
    public class BaixaTituloFuncionario
    {
        public int Id { get; set; }
        public int TituloId { get; set; }
        public int? NumeroNota { get; set; }
        public string? NomeCliente { get; set; }
        public string Valor { get; set; }
        
        public string? Observacao { get; set; }
        public string? Vendedor { get; set; }
        public string? Loja { get; set; }
        public string? UsuarioId { get; set; }
        public string? ImagemUrl { get; set; }
        public string? DataVenda { get; set; }
        public string? DataPrevistaPagamento { get; set; }
        public DateTime DataTime { get; set; }
        public TituloReceberFuncionario? TituloReceberFuncionario { get; set; }
    }
}
