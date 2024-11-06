using EntregaTitulo.Domain.Entities;
using EntregaTitulo.Domain.Interfaces.Repositories;
using EntregaTitulo.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Infra.Data.Repositories
{
    public class TituloReceberRepository : BaseRepository<TituloReceber, int>, ITituloReceberRepository
    {

        protected readonly DataContext _dataContext;
        public List<TituloReceber> GetAll(bool ativo)
        {
            using (var dataContext = new DataContext())
                return dataContext
                    .Set<TituloReceber>()

                    .OrderBy(p => p.NomeCliente)

                    .ToList();
        }

        public override List<TituloReceber> GetAll()
        {
            using (var dataContext = new DataContext())
                return dataContext
                    .Set<TituloReceber>()

                    .OrderBy(p => p.NomeCliente)

                    .ToList();
        }
    }
}
