using System.ComponentModel.DataAnnotations;

namespace EntregaTitulo.Services.Model.EntregaModel.PendenciaEntrega
{
    public class PendenciaEntregaPostModel
    {

        public string? ObservacaoPendencia { get; set; }

        public string? DataEntregaProximaEntrega { get; set; }
       
        public string? DiaSemanaPendencia { get; set; }
    }
}
