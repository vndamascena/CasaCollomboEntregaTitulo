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
    public class EntregaRepository : BaseRepository<Entrega, int>, IEntregaRepository
    {

        protected readonly DataContext _dataContext;
        public  List<Entrega> GetAll(bool ativo)
        {
            using (var dataContext = new DataContext())
                return dataContext
                    .Set<Entrega>()
                    
                    .OrderBy(p => p.NomeCliente)

                    .ToList();
        }
        public override List<Entrega> GetAll()
        {
            using (var dataContext = new DataContext())
                return dataContext
                    .Set<Entrega>()

                    .OrderBy(p => p.NomeCliente)

                    .ToList();
        }
    }
}
