using AutoMapper;
using EntregaTitulo.Domain.Entities;
using EntregaTitulo.Services.Model.EntregaModel.BaixaEntrega;
using EntregaTitulo.Services.Model.EntregaModel.Entrega;
using EntregaTitulo.Services.Model.EntregaModel.Impressao;
using EntregaTitulo.Services.Model.EntregaModel.Pagamento;
using EntregaTitulo.Services.Model.EntregaModel.PendenciaEntrega;
using EntregaTitulo.Services.Model.TituloModel.BaixaTitulo;
using EntregaTitulo.Services.Model.TituloModel.TituloReceber;

namespace EntregaTitulo.Services.Mappings
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {
            CreateMap<EntregaPostModel, Entrega>()
                .AfterMap((model, entity) =>
                {
                    entity.DataCadastro = DateTime.Now;
                    entity.Ativo = true;

                });
            CreateMap<TituloReceberPostModel, TituloReceber>()
                .AfterMap((model, entity) =>
                {
                    entity.DataCadastro = DateTime.Now;
                    entity.Ativo = true;
                });
            CreateMap<TituloReceberFuncionarioPostModel, TituloReceberFuncionario>()
               .AfterMap((model, entity) =>
               {
                   entity.DataCadastro = DateTime.Now;
                   entity.Ativo = true;
               });
            CreateMap<BaixaEntregaPostModel, BaixaEntrega>()
                .AfterMap((model, entity) =>
                {
                    entity.DataTime = DateTime.Now;
                });
            CreateMap<BaixaTituloPostModel, BaixaTitulo>()
                .AfterMap((model, entity) =>
                {
                    entity.DataTime = DateTime.Now;
                });
            CreateMap<BaixaTituloFuncionarioPostModel, BaixaTituloFuncionario>()
               .AfterMap((model, entity) =>
               {
                   entity.DataTime = DateTime.Now;
               });
            CreateMap<PendenciaEntregaPostModel, PendenciaEntrega>()

                .AfterMap((model, entity) =>
                {
                    entity.DataTime = DateTime.Now;
                });
            CreateMap<ImpressaoPostModel, Impressao>()
                .AfterMap((model, entity) =>
                {
                    entity.DataTime = DateTime.Now;
                });
            CreateMap<PagamentoPostModel, Pagamento>()
               .AfterMap((model, entity) =>
               {
                   entity.DataTime = DateTime.Now;
               });

            CreateMap<Entrega, EntregaGetModel>();
            CreateMap<EntregaGetModel, Entrega>();
            CreateMap<EntregaPutModel, Entrega>();
            CreateMap<Entrega, EntregaPutModel>();
            CreateMap<TituloReceberPutModel, TituloReceber>();
            CreateMap<TituloReceber, TituloReceberPutModel>();
            CreateMap<BaixaEntrega, BaixaEntregaGetModel>();
            CreateMap<BaixaTitulo, BaixaTituloGetModel>();
            CreateMap<PendenciaEntrega, PendenciaEntregaGetModel>();
            CreateMap<Impressao, ImpressaoGetModel>();
            CreateMap<ImpressaoGetModel, Impressao>();
            CreateMap<PagamentoGetModel, Pagamento>();
            CreateMap<Pagamento, PagamentoGetModel>();
            CreateMap<TituloReceber, TituloReceberGetModel>();
            CreateMap<TituloReceberGetModel, TituloReceber>();

            CreateMap<TituloReceberFuncionarioPutModel, TituloReceberFuncionario>();
            CreateMap<TituloReceberFuncionario, TituloReceberFuncionarioPutModel>();
            CreateMap<BaixaTituloFuncionario, BaixaTituloFuncionarioGetModel>();
            CreateMap<TituloReceberFuncionario, TituloReceberFuncionarioGetModel>();
            CreateMap<TituloReceberFuncionarioGetModel, TituloReceberFuncionario>();



        }
    }
}
