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
    public class ImpressaoRepository : BaseRepository<Impressao, int>, IImpressaoRepository
    {
        protected readonly DataContext _dataContext;
        public List<Impressao> GetAll(bool ativo)
        {
            using (var dataContext = new DataContext())
                return dataContext
                    .Set<Impressao>()

                    .OrderBy(p => p.DataTime)

                    .ToList();
        }

        public List<Impressao> GetByUsuarioId(string matricula)
        {
            throw new NotImplementedException();
        }
    }

       
    
}

