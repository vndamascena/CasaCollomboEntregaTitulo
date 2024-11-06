namespace EntregaTitulo.Services.Model.TituloModel.BaixaTitulo
{
    public class BaixaTituloGetModel
    {
        public int Id { get; set; }
        public int? NumeroNota { get; set; }
        public int IdTitulo { get; set; }
        public string? NomeCliente { get; set; }
        public string Telefone { get; set; }
        public string? ImagemUrl { get; set; }
        public string? Observacao { get; set; }       
        public string? Vendedor { get; set; }
        public string? DataVenda { get; set; }
        public string? Loja { get; set; }
        public string? UsuarioId { get; set; }
        public DateTime DataTime { get; set; }
       
    }
}
