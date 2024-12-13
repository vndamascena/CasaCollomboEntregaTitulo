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
    public class EscalaRepository : BaseRepository<Escala, int>, IEscalaRepository
    {
        protected readonly DataContext _datacontext;
        public List<Escala> Get(int id)
        {
            using (var dataContext = new DataContext())
                return dataContext
                    .Set<Escala>()

                    .OrderBy(p => p.Nome)

                    .ToList();
        }
       

     
    }
}
