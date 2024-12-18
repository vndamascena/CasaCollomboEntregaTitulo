﻿
using EntregaTitulo.Domain.Interfaces.Repositories;
using EntregaTitulo.Domain.Interfaces.Services;
using EntregaTitulo.Domain.Services;
using EntregaTitulo.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace EntregaTitulo.Services.Extensions
{
    public class ServicesExtension
    {
        public static void AddServicesConfig(IServiceCollection services)
        {
            services.AddTransient<IEntregaDomainService, EntregaDomainService>();
            services.AddTransient<IEntregaRepository, EntregaRepository>();
            services.AddTransient<IPendenciaEntregaRepository, PendenciaEntregaRepository>();
            services.AddTransient<ITituloReceberDomainService, TituloReceberDomainService>();
            services.AddTransient<IBaixaTituloRepository, BaixaTituloRepository>();
            services.AddTransient<ITituloReceberRepository, TituloReceberRepository>();
            services.AddTransient<IBaixaEntregaRepository, BaixaEntregaRepository>();
            services.AddTransient<IImpressaoRepository, ImpressaoRepository>();
            services.AddTransient<IPagamentoRepository, PagamentoRepository>();
            services.AddTransient<ITituloReceberFuncionarioDomainService, TituloReceberFuncionarioDomainService>();
            services.AddTransient<IBaixaTituloFuncionarioRepository, BaixaTituloFuncionarioRepository>();
            services.AddTransient<ITituloReceberFuncionarioRespository, TituloReceberFuncionarioRepository>();
            services.AddTransient<IEscalaRepository, EscalaRepository>();
            services.AddTransient<IHomeDomainService, HomeDomainService>();


        }
    }
}
