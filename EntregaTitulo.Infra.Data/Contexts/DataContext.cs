
using EntregaTitulo.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Substitua a string de conexão padrão pelo MySQL
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDENTREGATITULO;Integrated Security=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntregaMap());
            modelBuilder.ApplyConfiguration(new PendenciaEntregaMap());
            modelBuilder.ApplyConfiguration(new BaixaEntregaMap());
            modelBuilder.ApplyConfiguration(new ImpressaoMap());
            modelBuilder.ApplyConfiguration(new PagamentoMap());
            modelBuilder.ApplyConfiguration(new BaixaTituloReceberMap());
            modelBuilder.ApplyConfiguration(new TituloReceberMap());

        }
    }
}
