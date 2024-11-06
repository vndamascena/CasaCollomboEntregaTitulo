using EntregaTitulo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Domain.Interfaces.Repositories
{
    public interface IBaixaTituloRepository: IBaseRepository<BaixaTitulo, int>
    { 
        List<BaixaTitulo>GetBaixaTituloId(int tituloId);
        List<BaixaTitulo>GetByUsarioId(int matricula);
    }
}
