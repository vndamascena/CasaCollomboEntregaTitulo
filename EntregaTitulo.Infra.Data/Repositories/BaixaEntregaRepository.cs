using EntregaTitulo.Domain.Entities;
using EntregaTitulo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Infra.Data.Repositories
{
    public class BaixaEntregaRepository : BaseRepository<BaixaEntrega, int>, IBaixaEntregaRepository
    {
        public List<BaixaEntrega> GetBaixaEntregaId(int entregaId)
        {
            throw new NotImplementedException();
        }

        public List<BaixaEntrega> GetByUsuarioId(string matricula)
        {
            throw new NotImplementedException();
        }
    }
}
