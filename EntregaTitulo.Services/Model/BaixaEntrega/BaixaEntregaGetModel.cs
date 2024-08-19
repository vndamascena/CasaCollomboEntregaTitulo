namespace EntregaTitulo.Services.Model.BaixaEntrega
{
    public class BaixaEntregaGetModel
    {
        public int IdBaixaEntrega { get; set; }
        public int EntregaId { get; set; }
        public int? NumeroNota { get; set; }
        public string? NomeCliente { get; set; }
        public string? Valor { get; set; }
        public string? ImagemUrl { get; set; }
        public string? Observacao { get; set; }
        public string? DiaSemana { get; set; }
        public string? UsuarioId { get; set; }
        public string? Loja { get; set; }
        public DateTime DataTime { get; set; }


    }
}
