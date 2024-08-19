using EntregaTitulo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Interfaces.Repositories
{
    public interface IBaixaEntregaRepository: IBaseRepository<BaixaEntrega, int>
    {
        List<BaixaEntrega> GetBaixaEntregaId(int entregaId);
        List<BaixaEntrega> GetByUsuarioId(string matricula);
    }
}
