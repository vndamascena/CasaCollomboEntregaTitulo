﻿namespace EntregaTitulo.Services.Model.TituloModel.TituloReceber
{
    public class TituloReceberGetModel
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public int NumeroNota { get; set; }
        public string DataVenda { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Telefone { get; set; }
        public string Valor { get; set; }
        public string? ImagemUrl { get; set; }
        public string? Observacao { get; set; }
        public string? Vendedor { get; set; }
        public string? Loja { get; set; }
        public string? UsuarioId { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string? UsuarioIdAtualizador { get; set; }
    }
}