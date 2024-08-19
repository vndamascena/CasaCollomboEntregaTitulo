using System.ComponentModel.DataAnnotations;

namespace EntregaTitulo.Services.Model.Entrega
{
    public class EntregaGetModel
    {
        public int Id { get; set; }
        public int? NumeroNota { get; set; }
        public string? NomeCliente { get; set; }
        public string? Valor { get; set; }
        public string? ImagemUrl { get; set; }
        public string? DiaSemana { get; set; }
        public string? UsuarioId { get; set; }
        public string? Observacao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string? Loja { get; set; }

    }
}
