using EntregaTitulo.Domain.Entities;
using EntregaTitulo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Interfaces.Services
{
    public interface IEntregaDomainService
    {
        Entrega Cadastrar(Entrega entrega, string matricula);
        Entrega Atualizar(Entrega entrega);
        Entrega AtualizarMotorista(Entrega entrega);
        Entrega CadastrarMotorista(Entrega entrega);
        Entrega Delete(int id);
        List<Entrega> Consultar();
        List<BaixaEntrega> ConsultarBaixa();
        List<PendenciaEntrega> ConsultarPendencia();
        List<Impressao> ConsultarImpressao();
        BaixaEntrega BaixaEntrega(int id, string matricula);
        void PendenciaEntrega(int id, string matricula, string observacaoPendencia, string dataEntregaProximaEntrega, string diaProximaPendencia);
        void Impressao(int id, string matricula);


        Entrega ObterPorId(int id);

    }
}
