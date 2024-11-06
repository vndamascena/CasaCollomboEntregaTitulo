using EntregaTitulo.Domain.Entities;
using EntregaTitulo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Infra.Data.Repositories
{
    public  class BaixaTituloRepository : BaseRepository<BaixaTitulo, int>, IBaixaTituloRepository
    {
        public List<BaixaTitulo> GetBaixaTituloId(int tituloId)
        {
            throw new NotImplementedException();
        }

        public List<BaixaTitulo> GetByUsarioId(int matricula)
        {
            throw new NotImplementedException();
        }
    }

}
