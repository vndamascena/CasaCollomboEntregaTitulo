
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

           
            services.AddTransient<IBaixaEntregaRepository, BaixaEntregaRepository>();
            services.AddTransient<IImpressaoRepository, ImpressaoRepository>();


        }
    }
}
