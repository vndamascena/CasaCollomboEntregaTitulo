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
    public class PagamentoRepository : BaseRepository<Pagamento, int>, IPagamentoRepository
    {
        protected readonly DataContext _dataContext;
        public List<Pagamento> GetAll(bool ativo)
        {
            using (var dataContext = new DataContext())
                return dataContext
                    .Set<Pagamento>()

                    .OrderBy(p => p.DataTime)

                    .ToList();
        }

        public List<Pagamento> GetByUsuarioId(string matricula)
        {
            throw new NotImplementedException();
        }
    }
}

