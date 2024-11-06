namespace EntregaTitulo.Services.Model.TituloModel.TituloReceber
{
    public class TituloReceberPutModel
    {
        public int Id { get; set; }
        public int NumeroNota { get; set; }
        public string NomeCliente { get; set; }
        public string Valor { get; set; }
        public string Telefone { get; set; }
        
        public string? Observacao { get; set; }
    }
}
